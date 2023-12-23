using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREMVC.Models.Orders;
using Project.COREMVC.Models.PageVms;
using Project.COREMVC.Models.SessionService;
using Project.COREMVC.Models.ShoppingTools;
using Project.ENTITES.Models;
using System.Net.Http;
using System.Text;
using X.PagedList;

namespace Project.COREMVC.Controllers
{
    public class ShoppingController : Controller
    {
        readonly IProductManager _productManager;
        readonly ICategoryManager _categoryManager;
        readonly IOrderManager _orderManager;
        readonly IOrderDetailManager _orderDetailManager;
        readonly IHttpClientFactory _httpClientFactory;
        readonly UserManager<AppUser> _userManager;
        IMapper _mapper;

        public ShoppingController(IProductManager productManager, ICategoryManager categoryManager, IOrderManager orderManager, IOrderDetailManager orderDetailManager, IMapper mapper, UserManager<AppUser> userManager, IHttpClientFactory httpClientFactory)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
            _orderManager = orderManager;
            _orderDetailManager = orderDetailManager;
            _mapper = mapper;
            _httpClientFactory = httpClientFactory;
            _userManager = userManager;
        }
        public IActionResult Index(int? page, int? categoryID)
        {
            
            ShoppingPageVM spVm = new ShoppingPageVM()
            {
                Products = categoryID == null ? _mapper.Map<List<Product>>(_productManager.GetActives()).ToPagedList(page ?? 1, 5):
                _mapper.Map<List<Product>>(_productManager.GetActives().Where(x => x.CategoryID == categoryID)).ToPagedList(page ?? 1, 5),

                Categories = _mapper.Map<List<Category>>(_categoryManager.GetActives())
            };

            if (categoryID != null) TempData["catID"] = categoryID;


            return View(spVm);
        }


        public async Task<IActionResult> AddToCart(int id)
        {
            Cart c = GetCartFromSession("scart") == null ? new Cart() : GetCartFromSession("scart");
            Product productToBeAdded = _mapper.Map<Product>( await _productManager.FindAsync(id));
            CartItem ci = new()
            {
                ID = productToBeAdded.ID,
                ProductName = productToBeAdded.ProductName,
                UnitPrice = productToBeAdded.UnitPrice,
                ImagePath = productToBeAdded.ImagePath,
              
                CategoryID = productToBeAdded.CategoryID
            };
            c.AddToCart(ci);

            SetCart(c);

            TempData["message"] = $"{ci.ProductName} isimli ürün sepete eklenmiştir";
            return RedirectToAction("Index");
        }

        private void SetCart(Cart c)
        {
            int n = 3;
            string[] arr = new string[3];
            int nn = n;

            while (n < 0)
            {
                nn--;
                arr[nn] = "#";
                foreach (string item in arr)
                {
                    Console.Write(item);
                }

            }
            HttpContext.Session.SetObject("scart", c);
        }

        public IActionResult CartPage()
        {
            if (GetCartFromSession("scart") == null)
            {
                TempData["message"] = "Sepetiniz su anda bos";
                return RedirectToAction("Index");
            }
            Cart c = HttpContext.Session.GetObject<Cart>("scart");
            return View(c); //Todo : PageVM refactoring'i unutmayın
        }

        public IActionResult DeleteFromCart(int id)
        {
            if (GetCartFromSession("scart") != null)
            {
                Cart c = GetCartFromSession("scart");
                c.RemoveFromCart(id);
                SetCart(c);

                ControlCart(c);


            }

            return RedirectToAction("CartPage");
        }

        void ControlCart(Cart c)
        {
            if (c.GetCartItems.Count == 0) HttpContext.Session.Remove("scart");
        }

        public IActionResult DecreaseFromCart(int id)
        {
            if (GetCartFromSession("scart") != null)
            {
                Cart c = GetCartFromSession("scart");
                c.Decrease(id);
                SetCart(c);
                ControlCart(c);

            }
            return RedirectToAction("CartPage");
        }



        Cart GetCartFromSession(string key)
        {
            return HttpContext.Session.GetObject<Cart>(key);
        }


        public IActionResult ConfirmOrder()
        {


            return View();
        }





        [HttpPost]
        public async Task<IActionResult> ConfirmOrder(OrderRequestPageVM ovm)
        {

            Cart c = GetCartFromSession("scart");
            ovm.Order.PriceOfOrder = ovm.PaymentRequestModel.ShoppingPrice = c.TotalPrice;



            //API Entegrasyonu    
            #region APIIntegration

            HttpClient client = _httpClientFactory.CreateClient();
            string jsonData = JsonConvert.SerializeObject(ovm.PaymentRequestModel);

            //Content : Icerik

            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");


            HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:5046/api/Transaction", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                if (User.Identity.IsAuthenticated)
                {
                    AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                    ovm.Order.AppUserID = appUser.Id; //Normalde Order'in icerisindeki Email ve NameDescription null gecilebilir olması gereken şeylerdir...Cünkü eger AppUserId Email ve isim zaten sistemdedir ve Order'in Email'ine gerek yoktur...Ama mevcut durumda bu yapılar null gecilemedigi icin burada tekrar yazıyoruz...
                    ovm.Order.Email = appUser.Email;
                    ovm.Order.NameDescription = appUser.UserName;
                }
             int orderID= await _orderManager.AddAndGetID(_mapper.Map<OrderDTO>( ovm.Order));
               
                foreach (CartItem item in c.GetCartItems)
                {
                    OrderDetail od = new();
                    od.OrderID = orderID;
                    od.ProductID = item.ID;
                    od.Quantity = item.Amount;
                    od.UnitPrice = item.UnitPrice;
                    await _orderDetailManager.AddAsync(_mapper.Map<OrderDetailDTO>(od));

                    //Stoktan da düsürelim

                    Product stoktanDusurulecek = _mapper.Map<Product>(await _productManager.FindAsync(item.ID));
                    stoktanDusurulecek.UnitInStock -= item.Amount;
                    await _productManager.UpdateAsync(_mapper.Map<ProductDTO>(stoktanDusurulecek));

                }

                TempData["message"] = "Siparişiniz bize basarıyla ulasmıstır.Tesekkür ederiz";

                HttpContext.Session.Remove("scart");
                return RedirectToAction("Index");
            }

            #endregion

            string result = await responseMessage.Content.ReadAsStringAsync();
            TempData["message"] = result;
            return RedirectToAction("Index");






        }
    }
}
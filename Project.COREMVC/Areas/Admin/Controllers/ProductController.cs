using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREMVC.Areas.Admin.Models.Products.PageVMS;
using Project.ENTITES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        IProductManager _productManager;
        ICategoryManager _categoryManager;
        IMapper _mapper;

        public ProductController(ICategoryManager categoryManager, IProductManager productManager, IMapper mapper)
        {
            _categoryManager = categoryManager;
            _productManager = productManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            ProductPageVM productPageVM = new()
            {
                Products = _mapper.Map<List<Product>>(_productManager.GetActives()),
                
            };
            return View(productPageVM);
        }

        public IActionResult CreateProduct()
        {
            List<Category> categories = new();
            List<CategoryDTO> categoriesDTO = _categoryManager.GetActives();
            foreach (CategoryDTO item in categoriesDTO)
            {
              
                categories.Add(_mapper.Map<Category>(item));
            }

            
            CreateProductPageVM cpVm = new CreateProductPageVM()
            {
                Categories = categories
            };
            return View(cpVm);
        }


        [HttpPost]
        public IActionResult CreateProduct(Product product, IFormFile formFile)
        {
            Guid uniqueName = Guid.NewGuid();

            string extension = Path.GetExtension(formFile.FileName);
            product.ImagePath = $"/images/{uniqueName}{extension}";
            string path = $"{Directory.GetCurrentDirectory()}/wwwroot{product.ImagePath}";
            FileStream stream = new FileStream(path, FileMode.Create);
            formFile.CopyTo(stream);

            _productManager.Add(_mapper.Map<ProductDTO>(product));

            return RedirectToAction("Index");

        }
        public async Task<ActionResult> UpdateProduct(int id)
        {
            Product product = _mapper.Map<Product>(await _productManager.FirstOrDefaultAsync(x => x.ID == id));
            UpdateProductPageVM updateProductPageVM = new()
            {
                ResponseModel= new()
                {
                    CategoryID = product.CategoryID,
                    ProductName = product.ProductName,
                    ID = product.ID,
                    Status = product.Status,
                    UnitInStock = product.UnitInStock,
                    UnitPrice = product.UnitPrice
                }
            };
            return View(updateProductPageVM);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductResponseModel ResponseModel)
        {
            Product product = new()
            {
                CategoryID=ResponseModel.CategoryID,
                ProductName=ResponseModel.ProductName,
                ID = ResponseModel.ID,
                UnitInStock=ResponseModel.UnitInStock,
                UnitPrice=ResponseModel.UnitPrice,
                ImagePath= "/images/TheWarrior.jpg",

            };
            
          

           await _productManager.UpdateAsync(_mapper.Map<ProductDTO>(product));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteProduct(int id)
        {
            _productManager.Delete(_mapper.Map<ProductDTO>(await _productManager.FindAsync(id)));
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREMVC.Models.DashboardTools.PageVMs;
using Project.COREMVC.Models.DashboardTools.ResponseModels;

namespace Project.COREMVC.Controllers
{
    public class DashboardController : Controller
    {
        readonly IAppUserManager _userManager;
        readonly IProductManager _productManager;
        public DashboardController(IAppUserManager userManager, IProductManager productManager)
        {
            _userManager = userManager;
            _productManager = productManager;
        }
        public IActionResult Index()
        {
            DashboardPageVM dashboardPageVM = new()
            {
                Dashboard = new DashboardResponseModel()
                {
                    ProductQuantity = _productManager.GetActives().Count,
                    UserQuantity = _userManager.GetActives().Count,
                }
            };

            return View(dashboardPageVM);
        }
    }
}

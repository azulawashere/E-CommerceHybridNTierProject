using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.COMMON.Tools;
using Project.COREMVC.Models;
using Project.COREMVC.Models.AppUser;
using Project.COREMVC.Models.AppUser.UserPageVms;
using Project.ENTITES.Models;
using System.Diagnostics;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Project.COREMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        readonly UserManager<AppUser> _userManager;
        readonly RoleManager<IdentityRole<int>> _roleManager;
        readonly SignInManager<AppUser> _signInManager;



        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, RoleManager<IdentityRole<int>> roleManager, SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       


        public IActionResult Register()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterModel model)
        {
            AppUser appUser = new()
            {
                UserName = model.UserName,
                Email = model.Email,
            };

            IdentityResult result = await _userManager.CreateAsync(appUser, model.Password);

            if (result.Succeeded)
            {
                #region RolKontrolIslemi
                IdentityRole<int> appRole = await _roleManager.FindByNameAsync("Member");
                if (appRole == null) await _roleManager.CreateAsync(new() { Name = "Member" });
                await _userManager.AddToRoleAsync(appUser, "Member");
                #endregion

                Guid specId = Guid.NewGuid();
                string body = $"Hesabýnýz olusturulmustur.Üyeliginizi onaylamak icin lütfen http://localhost:5110/Home/ConfirmEmail?specId={specId}&id={appUser.Id} linkine týklayýnýz";


                MailService.Send(model.Email, body: body);

                TempData["Message"] = "Emailinizi kontrol ediniz";
                return RedirectToAction("RedirectPanel");
            }

            return View();


        }

        public async Task<IActionResult> ConfirmEmail(Guid specId, int id)
        {

            AppUser user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                TempData["Message"] = "Kullanýcý bulunamadý";
                return RedirectToAction("RedirectPanel");
            }
            user.EmailConfirmed = true;
            await _userManager.UpdateAsync(user);
            TempData["Message"] = "Emailiniz basarýyla onaylandý";
            return RedirectToAction("SignIn");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult RedirectPanel()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Shopping");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInPageVm model)
        {
           

            AppUser appUser = await _userManager.FindByNameAsync(model.UserRegisterModel.UserName);

            SignInResult result = await _signInManager.PasswordSignInAsync(appUser, model.UserRegisterModel.Password, true, true);
            if (result.Succeeded)
            {
                IList<string> roles = await _userManager.GetRolesAsync(appUser);
                if (roles.Contains("Admin"))
                {
                    return RedirectToAction("Index", "Category", new { Area = "Admin" });
                }
                else if (roles.Contains("Member"))
                {
                    return RedirectToAction("Index","Shopping");
                }
                return RedirectToAction("Panel");
            }
            else if (result.IsNotAllowed)
            {
                return RedirectToAction("MailPanel");
            }
            TempData["Message"] = "Kullanýcý bulunamadý";

            return RedirectToAction("SignIn");
        }
        public IActionResult MailPanel()
        {
            return View();
        }
        [Authorize(Roles = "Member")]
        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction("SignIn");
        }
    }
}
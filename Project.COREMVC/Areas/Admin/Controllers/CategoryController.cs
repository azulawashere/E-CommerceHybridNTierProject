using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;

using Project.ENTITES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        readonly ICategoryManager _categoryManager;
        IMapper _mapper;

        public CategoryController(ICategoryManager categoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _categoryManager = categoryManager;
        }

        

        public IActionResult Index()
        {
            if(!User.Identity.IsAuthenticated)
                RedirectToAction("Index","Home");

            return View(_mapper.Map<List<Category>>( _categoryManager.GetAll()));
        }


        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category model)
        {
        
            await _categoryManager.AddAsync(_mapper.Map<CategoryDTO>(model));
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryManager.Delete(await _categoryManager.FindAsync(id));
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DestroyCategory(int id)
        {
            TempData["Message"] = _categoryManager.Destroy(await _categoryManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateCategory(int id)
        {
            return View(_mapper.Map<Category>( await _categoryManager.FindAsync(id)));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(Category model)
        {
            await _categoryManager.UpdateAsync(_mapper.Map<CategoryDTO>(model));
            return RedirectToAction("Index");
        }
    }
}

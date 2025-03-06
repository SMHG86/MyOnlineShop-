using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Services;

namespace MyOnlineShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService) 
        {
            _categoryService = categoryService;
        }

        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult ProductsByCategory(int id)
        {
            return View();
        }
    }
}

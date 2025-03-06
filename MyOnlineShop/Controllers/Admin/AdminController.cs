using Microsoft.AspNetCore.Mvc;

namespace MyOnlineShop.Controllers.Admin
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            // داشبورد پنل مدیریت
            return View();
        }
    }
}

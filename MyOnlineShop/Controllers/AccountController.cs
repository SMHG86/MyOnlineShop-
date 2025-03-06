using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.ViewModels;

namespace MyOnlineShop.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Register()
        {
            // نمایش فرم ثبت‌نام کاربر
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model) // RegisterViewModel فرضی
        {
            // دریافت اطلاعات ثبت‌نام از فرم و ایجاد حساب کاربری جدید
            
            if (ModelState.IsValid)
            {
                // ... ثبت‌نام کاربر با استفاده از سرویس ...
                return RedirectToAction(nameof(Login)); 
            }
            return View(model); 
        }

        public IActionResult Login()
        {
            // نمایش فرم ورود کاربر
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model) 
        {
            // دریافت اطلاعات ورود از فرم و احراز هویت کاربر
            
            if (ModelState.IsValid)
            {
                // ... احراز هویت کاربر با استفاده از سرویس ...
                return RedirectToAction("Index", "Home"); 
            }
            return View(model); 
        }

        public IActionResult Logout()
        {
            // خروج کاربر از سیستم
            
            return RedirectToAction("Index", "Home"); 
        }

    }
}

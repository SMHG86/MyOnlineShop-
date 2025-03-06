using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Services;
using MyOnlineShop.ViewModels.Admin;

namespace MyOnlineShop.Controllers.Admin
{
    [Area("Admin")]
    public class SettingAdminController : Controller
    {

        private readonly ISettingService _settingService; 

        
        public SettingAdminController(ISettingService settingService)
        {
            _settingService = settingService;
        }

        public IActionResult Index()
        {
            // نمایش فرم تنظیمات فروشگاه در پنل مدیریت
            return View();
        }

        [HttpPost]
        public IActionResult Index(SettingAdminViewModel model)
        {
            // دریافت اطلاعات تنظیمات از فرم و ذخیره در پایگاه داده
            
            if (ModelState.IsValid)
            {
                // ... به‌روزرسانی تنظیمات با استفاده از _settingService ...
                ViewBag.SuccessMessage = "تنظیمات با موفقیت ذخیره شدند.";
            }
            else
            {
                ViewBag.ErrorMessage = "خطا در ذخیره تنظیمات. لطفا اطلاعات را بررسی کنید.";
            }
            return View(model); 
        }
    }
}

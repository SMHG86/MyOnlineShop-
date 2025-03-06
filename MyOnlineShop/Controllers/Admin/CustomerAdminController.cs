using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Services;
using MyOnlineShop.ViewModels.Admin;

namespace MyOnlineShop.Controllers.Admin
{
    [Area("Admin")]
    public class CustomerAdminController : Controller
    {

        private readonly ICustomerService _customerService;


        public CustomerAdminController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            // نمایش لیست مشتریان در پنل مدیریت

            return View();
        }

        public IActionResult Details(int id)
        {
            // نمایش جزئیات یک مشتری خاص در پنل مدیریت بر اساس ID

            return View();
        }

        public IActionResult Edit(int id)
        {
            // نمایش فرم ویرایش مشتری بر اساس ID

            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, CustomerAdminViewModel model)
        {
            // دریافت اطلاعات ویرایش شده مشتری از فرم و به‌روزرسانی در پایگاه داده

            if (ModelState.IsValid)
            {
                // ... به‌روزرسانی مشتری با استفاده از _customerService ...
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult ManageRoles(int id)
        {
            // نمایش فرم مدیریت نقش‌های مشتری بر اساس ID
            return View();
        }

        [HttpPost]
        public IActionResult ManageRoles(int id, ManageRolesAdminViewModel model)
        {
            // دریافت اطلاعات نقش‌های کاربری از فرم و به‌روزرسانی نقش‌های مشتری در پایگاه داده

            if (ModelState.IsValid)
            {
                // ... به‌روزرسانی نقش‌های مشتری با استفاده از _customerService ...
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}

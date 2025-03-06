using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Services;
using MyOnlineShop.ViewModels.Admin;

namespace MyOnlineShop.Controllers.Admin
{
    public class CategoryAdminController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryAdminController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            // نمایش لیست دسته‌بندی‌ها در پنل مدیریت
            return View();
        }

        public IActionResult Create()
        {
            // نمایش فرم ایجاد دسته‌بندی جدید
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryAdminViewModel model)
        {
            // دریافت اطلاعات دسته‌بندی جدید از فرم و ذخیره در پایگاه داده

            if (ModelState.IsValid)
            {
                // ... ایجاد دسته‌بندی با استفاده از _categoryService ...
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            // نمایش فرم ویرایش دسته‌بندی بر اساس ID
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, CategoryAdminViewModel model)
        {
            // دریافت اطلاعات ویرایش شده دسته‌بندی از فرم و به‌روزرسانی در پایگاه داده

            if (ModelState.IsValid)
            {

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            // نمایش صفحه تایید حذف دسته‌بندی بر اساس ID

            return View();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // حذف قطعی دسته‌بندی از پایگاه داده

            return RedirectToAction(nameof(Index));
        }
    }
}

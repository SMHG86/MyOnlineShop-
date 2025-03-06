using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Services;
using MyOnlineShop.ViewModels.Admin;

namespace MyOnlineShop.Controllers.Admin
{
    [Area("Admin")]
    public class ProductAdminController : Controller
    {
        private readonly IProductService _productService;

        public ProductAdminController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            // نمایش لیست محصولات در پنل مدیریت
            return View();
        }

        public IActionResult Create()
        {
            // نمایش فرم ایجاد محصول جدید
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductAdminViewModel model)
        {
            // دریافت اطلاعات محصول جدید از فرم و ذخیره در پایگاه داده و اعتبارسنجی
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            // نمایش فرم ویرایش محصول بر اساس ID
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, ProductAdminViewModel model)
        {
            // دریافت اطلاعات ویرایش شده محصول از فرم و به‌روزرسانی در پایگاه داده و اعتبار سنجی
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            // نمایش صفحه تایید حذف محصول بر اساس ID
            return View();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // حذف قطعی محصول از پایگاه داده
            return RedirectToAction(nameof(Index), id);     
        }


    }
}

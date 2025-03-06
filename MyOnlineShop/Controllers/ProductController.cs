using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Services;


namespace MyOnlineShop.Controllers
{
    public class ProductController : Controller
    {
        //سرویس محصولات 
        private readonly IProductService _productService;

        //برای دپندنسی 
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            //صفحه اصلی محصولات و دریافت محصول و ارسال به ویو
            return View();
        }

        public IActionResult Details(int id)
        {
            // نمایش محصول بر اساس ای دی و دریافت و ارسال به ویو
            return View();
        }
        public IActionResult Search(string query)
        {
            {
                return View();
            }
        }

        public IActionResult ProductsByCategory(int categoryId)
        {
            // نمایش محصولات دسته بندی و ارسال به ویو
            return View();
        }
    }
}

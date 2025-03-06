using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Services;

namespace MyOnlineShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }
         
        public IActionResult Index()
        {
            //نمایش سبد خرید و دریافت از سرویس و ارسال به ویو
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int quantity)
        {
            //افزودن محصول به سبد خرید
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult UpdataCartItem(int cartItemId, int quantity)
        {
            //به روزرسانی تعداد یک ایتم در سبدخرید
            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveFromCart(int cartItemId) 
        {
            //حذف یک ایتم از سبدخرید
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Checkout()
        {
            //نمایش صفحه پرداخت
            return View();
        }

        public IActionResult PlaceOrder()
        {
            //اعتبارسنجی اطلاعات پرداخت و ثبت سفارش از طریق سرویس و انتقال به صفحه تایید سفارش
            return RedirectToAction("OrderConfirmation");
        }

        public IActionResult OrderConfirmation()
        {
            // نمایش صفحه تایید سفارش
            return View();  
        }
    }

}

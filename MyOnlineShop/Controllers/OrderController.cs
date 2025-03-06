using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Services;

namespace MyOnlineShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Details(int id)
        {
            // نمایش جزئیات یک سفارش خاص بر اساس ای دی
            return View();
        }

        public IActionResult OrderHistory()
        {
            // نمایش تاریخچه سفارشات مشتری (لیست سفارشات)

            return View();
        }
    }
}

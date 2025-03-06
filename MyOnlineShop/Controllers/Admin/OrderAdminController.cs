using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Services;

namespace MyOnlineShop.Controllers.Admin
{
    [Area("Admin")]
    public class OrderAdminController : Controller
    {
        private readonly IOrderService _orderService; 

        
        public OrderAdminController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            // نمایش لیست سفارشات در پنل مدیریت
            
            return View();
        }

        public IActionResult Details(int id)
        {
            // نمایش جزئیات یک سفارش خاص در پنل مدیریت بر اساس ID
            
            return View();
        }
    }

}

using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Services;

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
    }
}

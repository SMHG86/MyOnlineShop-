using System;

namespace MyOnlineShop.ViewModels.Admin
{
    public class OrderAdminViewModel
    {

        public int Id { get; set; } // شناسه سفارش
        public string OrderNumber { get; set; } // شماره سفارش
        public DateTime OrderDate { get; set; } // تاریخ ثبت سفارش
        public decimal TotalAmount { get; set; } // مبلغ کل سفارش
        public string OrderStatus { get; set; } // وضعیت سفارش
        public CustomerViewModel Customer { get; set; } // اطلاعات مشتری سفارش‌دهند
    }
}

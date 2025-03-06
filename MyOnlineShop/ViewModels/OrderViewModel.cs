using System;
using System.Collections.Generic;

namespace MyOnlineShop.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; } // شناسه سفارش
        public string OrderNumber { get; set; } // شماره سفارش
        public DateTime OrderDate { get; set; } // تاریخ ثبت سفارش
        public decimal TotalAmount { get; set; } // مبلغ کل سفارش
        public string OrderStatus { get; set; } // وضعیت سفارش
      public List<OrderItemViewModel> OrderItems { get; set; } // لیست آیتم‌های سفارش
      public CustomerViewModel Customer { get; set; } // اطلاعات مشتری سفارش‌دهنده
      public AddressViewModel ShippingAddress { get; set; } // آدرس حمل و نقل
      public AddressViewModel BillingAddress { get; set; } // آدرس صورتحساب
      public PaymentMethodViewModel PaymentMethod { get; set; } // روش پرداخت
      public ShippingMethodViewModel ShippingMethod { get; set; } // روش حمل و نقل

    }


    public class OrderItemViewModel
    {
        public int ProductId { get; set; } // شناسه محصول
        public string ProductName { get; set; } // نام محصول
        public decimal ProductPrice { get; set; } // قیمت واحد محصول
        public int Quantity { get; set; } // تعداد محصول در سفارش
        public decimal LineTotal { get; set; } // قیمت کل این آیتم (قیمت واحد * تعداد)
    }

    public class AddressViewModel
    {
        public string FirstName { get; set; } // نام
        public string LastName { get; set; } // نام خانوادگی
        public string Email { get; set; } // ایمیل
        public string PhoneNumber { get; set; } // شماره تلفن
        public string AddressLine1 { get; set; } // آدرس خط 1
        public string AddressLine2 { get; set; } // آدرس خط 2 (اختیاری)
        public string City { get; set; } // شهر
        public string StateProvince { get; set; } // استان/ایالت
        public string ZipPostalCode { get; set; } // کد پستی
        public string Country { get; set; } // کشور
    }

    public class PaymentMethodViewModel
    {
        public int Id { get; set; } // شناسه روش پرداخت
        public string Name { get; set; } // نام روش پرداخت
        public string Description { get; set; } // توضیحات روش پرداخت
    }

    public class ShippingMethodViewModel
    {
        public int Id { get; set; } // شناسه روش حمل و نقل
        public string Name { get; set; } // نام روش حمل و نقل
        public string Description { get; set; } // توضیحات روش حمل و نقل
        public decimal Price { get; set; } // قیمت حمل و نقل
    }

    public class CustomerViewModel
    {
        public int Id { get; set; } // شناسه مشتری
        public string FirstName { get; set; } // نام
        public string LastName { get; set; } // نام خانوادگی
        public string Email { get; set; } // ایمیل
        // می‌توانید خواص دیگر مانند شماره تلفن، تاریخ تولد و غیره را اضافه کنید
    }
}

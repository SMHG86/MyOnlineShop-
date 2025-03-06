using System.Collections.Generic;

namespace MyOnlineShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<ShoppingCartItemViewModel> CartItems { get; set; } // لیست آیتم‌های سبد خرید
        public decimal TotalPrice { get; set; } // قیمت کل سبد خرید
    }

    public class ShoppingCartItemViewModel
    {
        public int ProductId { get; set; } // شناسه محصول
        public string ProductName { get; set; } // نام محصول
        public decimal ProductPrice { get; set; } // قیمت واحد محصول
        public int Quantity { get; set; } // تعداد محصول در سبد خرید
        public string ProductImageUrl { get; set; } // URL تصویر محصول
        public decimal LineTotal { get; set; } // قیمت کل این آیتم (قیمت واحد * تعداد)
    }
}

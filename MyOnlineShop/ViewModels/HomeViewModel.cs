namespace MyOnlineShop.ViewModels
{
    public class HomeViewModel
    {
        public List<ProductViewModel> FeaturedProducts { get; set; } // محصولات ویژه
        public List<CategoryViewModel> PopularCategories { get; set; } // دسته‌بندی‌های محبوب
        public List<BannerViewModel> Banners { get; set; } // بنرهای تبلیغاتی
        public string WelcomeMessage { get; set; } // پیام خوش‌آمدگویی به کاربر
        public string StoreDescription { get; set; } // توضیحات کوتاه فروشگا}
    }
    

    public class BannerViewModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string LinkUrl { get; set; }
        public string Text { get; set; }
    }

}
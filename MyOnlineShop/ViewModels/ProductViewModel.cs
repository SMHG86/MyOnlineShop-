namespace MyOnlineShop.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int StockQuantity { get; set; }
        public bool IsPublished { get; set; }
        public bool IsFeatured { get; set; }
        public CategoryViewModel Category { get; set; } // اطلاعات دسته‌بندی محصول
        public ManufacturerViewModel Manufacturer { get; set; } // اطلاعات تولیدکننده محصول
        public VendorViewModel Vendor { get; set; } // اطلاعات فروشنده محصول (اگر چندفروشندگی دارید)
        public double? AverageRating { get; set; } // میانگین امتیاز محصول
        public int ReviewCount { get; set; } // تعداد نظرات محصول

        public string Sku { get; set; } // شناسه محصول (Stock Keeping Unit)
        public decimal? DiscountPrice { get; set; } // قیمت تخفیف‌خورده
        public bool IsOnSale { get; set; } // آیا محصول در فروش ویژه است؟
        public List<string> ImageGalleryUrls { get; set; } // گالری تصاویر محصول
        public List<ProductAttributeViewModel> Attributes { get; set; } // ویژگی‌های محصول (مانند سایز، رنگ و غیره)
        public List<ProductReviewViewModel> Reviews { get; set; } // نظرات کاربران درباره محصول
        public List<ProductTagViewModel> Tags { get; set; } // تگ‌های محصول
        public SeoMetadataViewModel SeoMetadata { get; set; } // اطلاعات SEO محصول
    }

    
    public class ManufacturerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
    }

    public class VendorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
    }

    public class ProductAttributeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class ProductReviewViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }
    }

    public class ProductTagViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SeoMetadataViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
    }
}
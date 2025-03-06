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
}

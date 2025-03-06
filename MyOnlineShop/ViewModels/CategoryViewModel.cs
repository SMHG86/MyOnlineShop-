namespace MyOnlineShop.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int ProductCount { get; set; } // تعداد محصولات در دسته‌بندی
        public List<CategoryViewModel> SubCategories { get; set; } // دسته‌بندی‌های فرعی
        public int? ParentCategoryId { get; set; } // شناسه دسته‌بندی والد
        public int DisplayOrder { get; set; } // ترتیب نمایش دسته‌بندی
        public bool IsPublished { get; set; }
        public bool IsFeatured { get; set; }
    }
}

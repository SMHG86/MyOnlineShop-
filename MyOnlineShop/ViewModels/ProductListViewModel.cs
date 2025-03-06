using System.Collections.Generic;

namespace MyOnlineShop.ViewModels
{
    public class ProductListViewModel
    {
        public List<ProductViewModel> Products { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string SearchQuery { get; set; }

        // خواص برای صفحه‌بندی (Pagination)
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 12; // تعداد محصولات در هر صفحه
        public int TotalProducts { get; set; }
        public int TotalPages => (int)System.Math.Ceiling((double)TotalProducts / PageSize);

        // خواص برای فیلترها و مرتب‌سازی (Filters & Sorting) - نمونه
        public decimal? MinPriceFilter { get; set; }
        public decimal? MaxPriceFilter { get; set; }
        public string SortBy { get; set; } // مثال: "PriceAsc", "PriceDesc", "NameAsc", "NameDesc"
        public List<CategoryViewModel> AvailableCategoriesForFilter { get; set; } // لیست دسته‌بندی‌ها برای فیلتر
    }
}

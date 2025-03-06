using System.Collections.Generic;

namespace MyOnlineShop.ViewModels
{
    public class ProductListViewModel
    {
        //public List<ProductViewModel> Products { get; set; } // لیست محصولات برای نمایش
        public int CategoryId { get; set; } // شناسه دسته‌بندی (اگر لیست محصولات مربوط به یک دسته‌بندی خاص باشد)
        public string CategoryName { get; set; } // نام دسته‌بندی (برای نمایش عنوان صفحه و غیره)
        public string SearchQuery { get; set; } // عبارت جستجو (اگر لیست محصولات نتیجه جستجو باشد
    }
}

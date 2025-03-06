using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MyOnlineShop.ViewModels.Admin
{
    public class ProductAdminViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "نام محصول الزامی است.")]
        public string Name { get; set; } // نام محصول

        [Required(ErrorMessage = "توضیحات کوتاه الزامی است.")]
        public string ShortDescription { get; set; } // توضیحات کوتاه محصول

        public string FullDescription { get; set; } // توضیحات کامل محصول

        [Required(ErrorMessage = "قیمت الزامی است.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "قیمت باید بیشتر از 0 باشد.")]
        public decimal Price { get; set; } // قیمت محصول

        public int CategoryId { get; set; } // شناسه دسته‌بندی محصول
       
        // برای نمایش لیست دسته‌بندی‌ها در فرم ایجاد/ویرایش:
        public List<CategoryViewModel> Categories { get; set; }

        public IFormFile ImageFile { get; set; } // فایل تصویر محصول برای آپلود
        public string ImageUrl { get; set; } // URL تصویر محصول (برای نمایش تصویر فعلی در فرم ویرایش)

        public int StockQuantity { get; set; } // موجودی انبار
        public bool IsPublished { get; set; } // آیا محصول منتشر شده است؟
        public bool IsFeatured { get; set; } // آیا محصول ویژه است؟
    }
}

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MyOnlineShop.ViewModels.Admin
{
    public class ProductAdminViewModel
    {
        public int Id { get; set; } // شناسه محصول (برای ویرایش)

        [Required(ErrorMessage = "نام محصول الزامی است.")]
        public string Name { get; set; } // نام محصول

        [Required(ErrorMessage = "توضیحات کوتاه الزامی است.")]
        public string ShortDescription { get; set; } // توضیحات کوتاه محصول

        public string FullDescription { get; set; } // توضیحات کامل محصول

        [Required(ErrorMessage = "قیمت الزامی است.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "قیمت باید بیشتر از 0 باشد.")]
        public decimal Price { get; set; } // قیمت محصول

        [Required(ErrorMessage = "دسته‌بندی الزامی است.")]
        public int CategoryId { get; set; } // شناسه دسته‌بندی محصول
        // برای نمایش لیست دسته‌بندی‌ها در فرم ایجاد/ویرایش:
         public List<CategoryViewModel> Categories { get; set; }

        public IFormFile ImageFile { get; set; } // فایل تصویر محصول برای آپلود
        public string ImageUrl { get; set; } // URL تصویر محصول (برای نمایش تصویر فعلی در فرم ویرایش)

        [Required(ErrorMessage = "موجودی انبار الزامی است.")]
        [Range(0, int.MaxValue, ErrorMessage = "موجودی انبار نمی‌تواند منفی باشد.")]
        public int StockQuantity { get; set; } // موجودی انبار
        public bool IsPublished { get; set; } // آیا محصول منتشر شده است؟
        public bool IsFeatured { get; set; } // آیا محصول ویژه است؟

        // خواص اختیاری بیشتر (می‌توانید بر اساس نیاز اضافه کنید):
        public string Sku { get; set; } // شناسه محصول (Stock Keeping Unit)
        public decimal? DiscountPrice { get; set; } // قیمت تخفیف‌خورده
        public bool IsOnSale { get; set; } // آیا محصول در فروش ویژه است؟
        public List<IFormFile> ImageGalleryFiles { get; set; } // فایل‌های گالری تصاویر محصول برای آپلود
        public List<string> ImageGalleryUrls { get; set; } // گالری تصاویر محصول (برای نمایش تصاویر فعلی در فرم ویرایش)
        public List<ProductAttributeAdminViewModel> Attributes { get; set; } // ویژگی‌های محصول برای مدیریت در پنل ادمین
        public List<int> TagIds { get; set; } // شناسه تگ‌های محصول انتخاب شده
        // برای نمایش لیست تگ‌ها در فرم ایجاد/ویرایش:
         public List<ProductTagViewModel> AvailableTags { get; set; }
        public string SeoTitle { get; set; } // عنوان SEO محصول
        public string SeoDescription { get; set; } // توضیحات SEO محصول
        public string SeoKeywords { get; set; } // کلمات کلیدی SEO محصول
    }

    public class ProductAttributeAdminViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

}
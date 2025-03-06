using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MyOnlineShop.ViewModels.Admin
{
    public class CategoryAdminViewModel
    {
        public int Id { get; set; } // شناسه دسته‌بندی (برای ویرایش)

        [Required(ErrorMessage = "نام دسته‌بندی الزامی است.")]
        public string Name { get; set; } // نام دسته‌بندی

        public string Description { get; set; } // توضیحات دسته‌بندی

        public IFormFile ImageFile { get; set; } // فایل تصویر دسته‌بندی برای آپلود
        public string ImageUrl { get; set; } // URL تصویر دسته‌بندی (برای نمایش تصویر فعلی در فرم ویرایش)

        public bool IsPublished { get; set; } // آیا دسته‌بندی منتشر شده است؟
        public bool IsFeatured { get; set; } // آیا دسته‌بندی ویژه است؟
    }
}

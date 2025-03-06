using System.ComponentModel.DataAnnotations;

namespace MyOnlineShop.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "ایمیل الزامی است.")]
        [EmailAddress(ErrorMessage = "ایمیل نامعتبر است.")]
        public string Email { get; set; } // ایمیل کاربر

        [Required(ErrorMessage = "رمز عبور الزامی است.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } // رمز عبور کاربر

        [Display(Name = "مرا به خاطر بسپار؟")]
        public bool RememberMe { get; set; } // آیا کاربر می‌خواهد "مرا به خاطر بسپار" فعال باشد؟

    }
}

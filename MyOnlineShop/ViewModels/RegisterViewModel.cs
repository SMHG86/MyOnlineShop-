using System.ComponentModel.DataAnnotations;

namespace MyOnlineShop.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "نام الزامی است.")]
        public string FirstName { get; set; } // نام کاربر

        [Required(ErrorMessage = "نام خانوادگی الزامی است.")]
        public string LastName { get; set; } // نام خانوادگی کاربر

        [Required(ErrorMessage = "ایمیل الزامی است.")]
        [EmailAddress(ErrorMessage = "ایمیل نامعتبر است.")]
        public string Email { get; set; } // ایمیل کاربر

        [Required(ErrorMessage = "رمز عبور الزامی است.")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "رمز عبور باید حداقل 6 کاراکتر و حداکثر 100 کاراکتر باشد.", MinimumLength = 6)]
        public string Password { get; set; } // رمز عبور کاربر

        [DataType(DataType.Password)]
        [Display(Name = "تایید رمز عبور")]
        [Compare("Password", ErrorMessage = "رمز عبور و تایید رمز عبور مطابقت ندارند.")]
        public string ConfirmPassword { get; set; } // تایید رمز عبور کاربر
    }
}

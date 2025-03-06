namespace MyOnlineShop.ViewModels.Admin
{
    public class CustomerAdminViewModel
    {

        public int Id { get; set; } // شناسه مشتری (برای ویرایش)
        public string FirstName { get; set; } // نام مشتری
        public string LastName { get; set; } // نام خانوادگی مشتری
        public string Email { get; set; } // ایمیل مشتری
        public bool IsActive { get; set; } // وضعیت فعال بودن مشتری

    }
}

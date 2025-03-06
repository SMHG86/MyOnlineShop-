using System.Collections.Generic;

namespace MyOnlineShop.ViewModels.Admin
{
    public class ManageRolesAdminViewModel
    {
        public int CustomerId { get; set; } // شناسه مشتری
        public string CustomerEmail { get; set; } // ایمیل مشتری (برای نمایش)
        public List<RoleViewModel> Roles { get; set; } // لیست نقش‌های کاربری موجود
        public List<int> SelectedRoleIds { get; set; } // لیست شناسه نقش‌های کاربری انتخاب شده برای مشتری

    }

    public class RoleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description  { get; set; }
    }
}

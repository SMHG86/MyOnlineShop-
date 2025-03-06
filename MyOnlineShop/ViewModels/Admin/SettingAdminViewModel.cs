namespace MyOnlineShop.ViewModels.Admin
{
    public class SettingAdminViewModel
    {
        public string StoreName { get; set; } // نام فروشگاه
        public string StoreDescription { get; set; } // توضیحات فروشگاه
        public string DefaultLanguage { get; set; } // زبان پیش‌فرض فروشگاه
        public string DefaultCurrency { get; set; } // واحد پول پیش‌فرض فروشگاه

    }
}

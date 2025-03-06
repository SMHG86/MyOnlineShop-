using MyOnlineShop.ViewModels.Admin;
namespace MyOnlineShop.Services
{
    public interface ISettingService
    {
        SettingAdminViewModel GetSettings();
        void UpdateSettings(SettingAdminViewModel model);
    }
}

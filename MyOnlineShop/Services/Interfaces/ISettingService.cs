using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Services.Interfaces
{
    public interface ISettingService
    {
        Setting GetSettings();
        void UpdateSettings(Setting setting);
    }
}
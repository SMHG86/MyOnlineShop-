using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories
{
    public interface ISettingRepository
    {
        Setting GetSettings(); // فقط یک رکورد تنظیمات داریم
        void UpdateSettings(Setting setting);
    }
}
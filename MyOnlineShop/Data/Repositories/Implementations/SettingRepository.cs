using System.Linq;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class SettingRepository : ISettingRepository
    {
        private readonly ApplicationDbContext _context;

        public SettingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Setting GetSettings()
        {
            return _context.Settings.FirstOrDefault();
        }

        public void UpdateSettings(Setting setting)
        {
            _context.Settings.Update(setting);
            _context.SaveChanges();
        }
    }
}
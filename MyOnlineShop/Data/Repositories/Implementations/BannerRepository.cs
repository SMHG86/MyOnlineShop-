using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class BannerRepository : IBannerRepository
    {
        private readonly ApplicationDbContext _context;

        public BannerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Banner GetBannerById(int bannerId)
        {
            return _context.Banners.Find(bannerId);
        }

        public List<Banner> GetAllBanners()
        {
            return _context.Banners.ToList();
        }

        public List<Banner> GetPublishedBanners()
        {
            return _context.Banners.Where(b => b.IsPublished).ToList();
        }

        public void AddBanner(Banner banner)
        {
            _context.Banners.Add(banner);
            _context.SaveChanges();
        }

        public void UpdateBanner(Banner banner)
        {
            _context.Banners.Update(banner);
            _context.SaveChanges();
        }

        public void DeleteBanner(int bannerId)
        {
            var banner = _context.Banners.Find(bannerId);
            if (banner != null)
            {
                _context.Banners.Remove(banner);
                _context.SaveChanges();
            }
        }
    }
}
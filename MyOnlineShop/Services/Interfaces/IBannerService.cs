using System.Collections.Generic;
using System.Reflection;
using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IBannerService
    {
        Banner GetBannerById(int bannerId);
        List<Banner> GetAllBanners();
        List<Banner> GetPublishedBanners();
        void AddBanner(Banner banner);
        void UpdateBanner(Banner banner);
        void DeleteBanner(int bannerId);
    }
}
using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories
{
    public interface IVendorRepository
    {
        Vendor GetVendorById(int vendorId);
        List<Vendor> GetAllVendors();
        Vendor GetVendorByName(string name); // پیدا کردن فروشنده بر اساس نام

        void AddVendor(Vendor vendor);
        void UpdateVendor(Vendor vendor);
        void DeleteVendor(int vendorId);
    }
}
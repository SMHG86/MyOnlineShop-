using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IVendorService
    {
        Vendor GetVendorById(int vendorId);
        List<Vendor> GetAllVendors();
        Vendor GetVendorByName(string name);
        void AddVendor(Vendor vendor);
        void UpdateVendor(Vendor vendor);
        void DeleteVendor(int vendorId);
    }
}
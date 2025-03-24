using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class VendorRepository : IVendorRepository
    {
        private readonly ApplicationDbContext _context;

        public VendorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Vendor GetVendorById(int vendorId)
        {
            return _context.Vendors.Find(vendorId);
        }

        public List<Vendor> GetAllVendors()
        {
            return _context.Vendors.ToList();
        }

        public Vendor GetVendorByName(string name)
        {
            return _context.Vendors.FirstOrDefault(v => v.Name == name);
        }

        public void AddVendor(Vendor vendor)
        {
            _context.Vendors.Add(vendor);
            _context.SaveChanges();
        }

        public void UpdateVendor(Vendor vendor)
        {
            _context.Vendors.Update(vendor);
            _context.SaveChanges();
        }

        public void DeleteVendor(int vendorId)
        {
            var vendor = _context.Vendors.Find(vendorId);
            if (vendor != null)
            {
                _context.Vendors.Remove(vendor);
                _context.SaveChanges();
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly ApplicationDbContext _context;

        public ManufacturerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Manufacturer GetManufacturerById(int manufacturerId)
        {
            return _context.Manufacturers.Find(manufacturerId);
        }

        public List<Manufacturer> GetAllManufacturers()
        {
            return _context.Manufacturers.ToList();
        }

        public Manufacturer GetManufacturerByName(string name)
        {
            return _context.Manufacturers.FirstOrDefault(m => m.Name == name);
        }

        public void AddManufacturer(Manufacturer manufacturer)
        {
            _context.Manufacturers.Add(manufacturer);
            _context.SaveChanges();
        }

        public void UpdateManufacturer(Manufacturer manufacturer)
        {
            _context.Manufacturers.Update(manufacturer);
            _context.SaveChanges();
        }

        public void DeleteManufacturer(int manufacturerId)
        {
            var manufacturer = _context.Manufacturers.Find(manufacturerId);
            if (manufacturer != null)
            {
                _context.Manufacturers.Remove(manufacturer);
                _context.SaveChanges();
            }
        }
    }
}
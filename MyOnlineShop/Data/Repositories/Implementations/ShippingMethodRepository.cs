using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class ShippingMethodRepository : IShippingMethodRepository
    {
        private readonly ApplicationDbContext _context;

        public ShippingMethodRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ShippingMethod GetShippingMethodById(int shippingMethodId)
        {
            return _context.ShippingMethods.Find(shippingMethodId);
        }

        public List<ShippingMethod> GetAllShippingMethods()
        {
            return _context.ShippingMethods.ToList();
        }

        public ShippingMethod GetShippingMethodByName(string name)
        {
            return _context.ShippingMethods.FirstOrDefault(sm => sm.Name == name);
        }

        public void AddShippingMethod(ShippingMethod shippingMethod)
        {
            _context.ShippingMethods.Add(shippingMethod);
            _context.SaveChanges();
        }

        public void UpdateShippingMethod(ShippingMethod shippingMethod)
        {
            _context.ShippingMethods.Update(shippingMethod);
            _context.SaveChanges();
        }

        public void DeleteShippingMethod(int shippingMethodId)
        {
            var shippingMethod = _context.ShippingMethods.Find(shippingMethodId);
            if (shippingMethod != null)
            {
                _context.ShippingMethods.Remove(shippingMethod);
                _context.SaveChanges();
            }
        }
    }
}
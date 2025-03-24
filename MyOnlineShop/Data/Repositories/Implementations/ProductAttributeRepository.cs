using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class ProductAttributeRepository : IProductAttributeRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductAttributeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ProductAttribute GetProductAttributeById(int productAttributeId)
        {
            return _context.ProductAttributes.Find(productAttributeId);
        }

        public List<ProductAttribute> GetAllProductAttributes()
        {
            return _context.ProductAttributes.ToList();
        }

        public ProductAttribute GetProductAttributeByName(string name)
        {
            return _context.ProductAttributes.FirstOrDefault(pa => pa.Name == name);
        }

        public void AddProductAttribute(ProductAttribute productAttribute)
        {
            _context.ProductAttributes.Add(productAttribute);
            _context.SaveChanges();
        }

        public void UpdateProductAttribute(ProductAttribute productAttribute)
        {
            _context.ProductAttributes.Update(productAttribute);
            _context.SaveChanges();
        }

        public void DeleteProductAttribute(int productAttributeId)
        {
            var productAttribute = _context.ProductAttributes.Find(productAttributeId);
            if (productAttribute != null)
            {
                _context.ProductAttributes.Remove(productAttribute);
                _context.SaveChanges();
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class ProductAttributeValueRepository : IProductAttributeValueRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductAttributeValueRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ProductAttributeValue GetProductAttributeValueById(int productAttributeValueId)
        {
            return _context.ProductAttributeValues.Find(productAttributeValueId);
        }

        public List<ProductAttributeValue> GetAllProductAttributeValues()
        {
            return _context.ProductAttributeValues.ToList();
        }

        public List<ProductAttributeValue> GetProductAttributeValuesByProductId(int productId)
        {
            return _context.ProductAttributeValues.Where(pav => pav.ProductId == productId).ToList();
        }

        public List<ProductAttributeValue> GetProductAttributeValuesByAttributeId(int productAttributeId)
        {
            return _context.ProductAttributeValues.Where(pav => pav.ProductAttributeId == productAttributeId).ToList();
        }

        public void AddProductAttributeValue(ProductAttributeValue productAttributeValue)
        {
            _context.ProductAttributeValues.Add(productAttributeValue);
            _context.SaveChanges();
        }

        public void UpdateProductAttributeValue(ProductAttributeValue productAttributeValue)
        {
            _context.ProductAttributeValues.Update(productAttributeValue);
            _context.SaveChanges();
        }

        public void DeleteProductAttributeValue(int productAttributeValueId)
        {
            var productAttributeValue = _context.ProductAttributeValues.Find(productAttributeValueId);
            if (productAttributeValue != null)
            {
                _context.ProductAttributeValues.Remove(productAttributeValue);
                _context.SaveChanges();
            }
        }
    }
}
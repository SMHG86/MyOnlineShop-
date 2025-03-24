using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public List<Product> GetFeaturedProducts()
        {
            return _context.Products.Where(p => p.IsFeatured).ToList();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> SearchProducts(string query)
        {
            return _context.Products.Where(p =>
                EF.Functions.Like(p.Name, $"%{query}%") ||
                EF.Functions.Like(p.ShortDescription, $"%{query}%") ||
                EF.Functions.Like(p.FullDescription, $"%{query}%")).ToList();
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
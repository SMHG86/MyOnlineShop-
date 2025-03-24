using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductImageRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ProductImage GetProductImageById(int productImageId)
        {
            return _context.ProductImages.Find(productImageId);
        }

        public List<ProductImage> GetAllProductImages()
        {
            return _context.ProductImages.ToList();
        }

        public List<ProductImage> GetProductImagesByProductId(int productId)
        {
            return _context.ProductImages.Where(pi => pi.ProductId == productId).ToList();
        }

        public void AddProductImage(ProductImage productImage)
        {
            _context.ProductImages.Add(productImage);
            _context.SaveChanges();
        }

        public void UpdateProductImage(ProductImage productImage)
        {
            _context.ProductImages.Update(productImage);
            _context.SaveChanges();
        }

        public void DeleteProductImage(int productImageId)
        {
            var productImage = _context.ProductImages.Find(productImageId);
            if (productImage != null)
            {
                _context.ProductImages.Remove(productImage);
                _context.SaveChanges();
            }
        }
    }
}
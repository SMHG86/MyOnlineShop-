using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class ProductTagRepository : IProductTagRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductTagRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ProductTag GetProductTagById(int productId, int tagId)
        {
            return _context.ProductTags.Find(new { ProductId = productId, TagId = tagId });
        }

        public List<ProductTag> GetAllProductTags()
        {
            return _context.ProductTags.ToList();
        }

        public List<ProductTag> GetProductTagsByProductId(int productId)
        {
            return _context.ProductTags.Where(pt => pt.ProductId == productId).ToList();
        }

        public List<ProductTag> GetProductTagsByTagId(int tagId)
        {
            return _context.ProductTags.Where(pt => pt.TagId == tagId).ToList();
        }

        public void AddProductTag(ProductTag productTag)
        {
            _context.ProductTags.Add(productTag);
            _context.SaveChanges();
        }

        public void DeleteProductTag(int productId, int tagId)
        {
            var productTag = _context.ProductTags.Find(new { ProductId = productId, TagId = tagId });
            if (productTag != null)
            {
                _context.ProductTags.Remove(productTag);
                _context.SaveChanges();
            }
        }
    }
}
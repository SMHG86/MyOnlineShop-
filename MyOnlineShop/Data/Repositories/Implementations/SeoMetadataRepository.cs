using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class SeoMetadataRepository : ISeoMetadataRepository
    {
        private readonly ApplicationDbContext _context;

        public SeoMetadataRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public SeoMetadata GetSeoMetadataById(int seoMetadataId)
        {
            return _context.SeoMetadatas.Find(seoMetadataId);
        }

        public SeoMetadata GetSeoMetadataByProductId(int productId)
        {
            return _context.SeoMetadatas.FirstOrDefault(sm => sm.ProductId == productId);
        }

        public SeoMetadata GetSeoMetadataByCategoryId(int categoryId)
        {
            return _context.SeoMetadatas.FirstOrDefault(sm => sm.CategoryId == categoryId);
        }

        public void AddSeoMetadata(SeoMetadata seoMetadata)
        {
            _context.SeoMetadatas.Add(seoMetadata);
            _context.SaveChanges();
        }

        public void UpdateSeoMetadata(SeoMetadata seoMetadata)
        {
            _context.SeoMetadatas.Update(seoMetadata);
            _context.SaveChanges();
        }

        public void DeleteSeoMetadata(int seoMetadataId)
        {
            var seoMetadata = _context.SeoMetadatas.Find(seoMetadataId);
            if (seoMetadata != null)
            {
                _context.SeoMetadatas.Remove(seoMetadata);
                _context.SaveChanges();
            }
        }
    }
}
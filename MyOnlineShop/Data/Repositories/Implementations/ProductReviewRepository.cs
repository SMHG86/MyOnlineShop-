using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class ProductReviewRepository : IProductReviewRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ProductReview GetProductReviewById(int productReviewId)
        {
            return _context.ProductReviews.Find(productReviewId);
        }

        public List<ProductReview> GetAllProductReviews()
        {
            return _context.ProductReviews.ToList();
        }

        public List<ProductReview> GetProductReviewsByProductId(int productId)
        {
            return _context.ProductReviews.Where(pr => pr.ProductId == productId).ToList();
        }

        public List<ProductReview> GetProductReviewsByCustomerId(int customerId)
        {
            return _context.ProductReviews.Where(pr => pr.CustomerId == customerId).ToList();
        }

        public void AddProductReview(ProductReview productReview)
        {
            _context.ProductReviews.Add(productReview);
            _context.SaveChanges();
        }

        public void UpdateProductReview(ProductReview productReview)
        {
            _context.ProductReviews.Update(productReview);
            _context.SaveChanges();
        }

        public void DeleteProductReview(int productReviewId)
        {
            var productReview = _context.ProductReviews.Find(productReviewId);
            if (productReview != null)
            {
                _context.ProductReviews.Remove(productReview);
                _context.SaveChanges();
            }
        }
    }
}
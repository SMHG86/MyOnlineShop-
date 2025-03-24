using System.Collections.Generic;
using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IProductReviewService
    {
        ProductReview GetProductReviewById(int productReviewId);
        List<ProductReview> GetAllProductReviews();
        List<ProductReview> GetProductReviewsByProductId(int productId);
        List<ProductReview> GetProductReviewsByCustomerId(int customerId);
        void AddProductReview(ProductReview productReview);
        void UpdateProductReview(ProductReview productReview);
        void DeleteProductReview(int productReviewId);
    }
}
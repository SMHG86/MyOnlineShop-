using System.Collections.Generic;
using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IProductImageService
    {
        ProductImage GetProductImageById(int productImageId);
        List<ProductImage> GetAllProductImages();
        List<ProductImage> GetProductImagesByProductId(int productId);
        void AddProductImage(ProductImage productImage);
        void UpdateProductImage(ProductImage productImage);
        void DeleteProductImage(int productImageId);
    }
}
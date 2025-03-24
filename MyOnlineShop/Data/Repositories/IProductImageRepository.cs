using System.Collections.Generic;
using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Data.Repositories
{
    public interface IProductImageRepository
    {
        ProductImage GetProductImageById(int productImageId);
        List<ProductImage> GetAllProductImages(); // برای پنل مدیریت - لیست کامل تصاویر محصول
        List<ProductImage> GetProductImagesByProductId(int productId);

        void AddProductImage(ProductImage productImage);
        void UpdateProductImage(ProductImage productImage);
        void DeleteProductImage(int productImageId);
    }
}
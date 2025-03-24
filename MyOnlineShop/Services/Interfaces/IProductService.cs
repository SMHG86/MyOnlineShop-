using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IProductService
    {
        Product GetProductById(int productId);
        List<Product> GetAllProducts();
        List<Product> GetFeaturedProducts();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> SearchProducts(string query);

        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}
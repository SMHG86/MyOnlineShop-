using MyOnlineShop.Models;
using System.Collections.Generic;

namespace MyOnlineShop.Data.Repositories
{
    public interface IProductRepository
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

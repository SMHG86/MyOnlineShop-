using System.Collections.Generic;
using MyOnlineShop.ViewModels;
using MyOnlineShop.ViewModels.Admin;

namespace MyOnlineShop.Services
{
    public interface IProductService
    {
        ProductViewModel GetProductById(int productId);
        List<ProductViewModel> GetAllProducts();
        List<ProductViewModel> GetFeaturedProducts();
        List<ProductViewModel> GetProductsByCategory(int categoryId);
        List<ProductViewModel> SearchProducts(string query);

        void CreateProduct(ProductAdminViewModel model);
        void UpdateProduct(int productId, ProductAdminViewModel model);
        void DeleteProduct(int productId);
    }
}

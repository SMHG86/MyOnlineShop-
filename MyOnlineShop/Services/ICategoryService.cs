using System.Collections.Generic;
using MyOnlineShop.ViewModels;
using MyOnlineShop.ViewModels.Admin;

namespace MyOnlineShop.Services
{
    public interface ICategoryService
    {
        CategoryViewModel GetCategoryById(int categoryId);
        List<CategoryViewModel> GetAllCategories();
        List<CategoryViewModel> GetFeaturedCategories();

        void CreateCategory(CategoryAdminViewModel model);
        void UpdateCategory(int categoryId, CategoryAdminViewModel model);
        void DeleteCategory(int categoryId);
    }
}

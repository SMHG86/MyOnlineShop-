﻿using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories
{
    public interface ICategoryRepository
    {
        Category GetCategoryById(int categoryId);
        List<Category> GetAllCategories();
        List<Category> GetFeaturedCategories();

        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int categoryId);
    }
}

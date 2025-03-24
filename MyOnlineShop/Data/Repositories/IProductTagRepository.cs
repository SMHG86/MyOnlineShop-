using System.Collections.Generic;
using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Data.Repositories
{
    public interface IProductTagRepository
    {
        ProductTag GetProductTagById(int productId, int tagId); // کلید ترکیبی
        List<ProductTag> GetAllProductTags(); // برای پنل مدیریت - لیست کامل ProductTag
        List<ProductTag> GetProductTagsByProductId(int productId);
        List<ProductTag> GetProductTagsByTagId(int tagId);

        void AddProductTag(ProductTag productTag);
        void DeleteProductTag(int productId, int tagId); // کلید ترکیبی
    }
}
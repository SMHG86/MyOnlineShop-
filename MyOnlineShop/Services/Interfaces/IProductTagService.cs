using System.Collections.Generic;
using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IProductTagService
    {
        ProductTag GetProductTagById(int productId, int tagId);
        List<ProductTag> GetAllProductTags();
        List<ProductTag> GetProductTagsByProductId(int productId);
        List<ProductTag> GetProductTagsByTagId(int tagId);
        void AddProductTag(ProductTag productTag);
        void DeleteProductTag(int productId, int tagId);
    }
}
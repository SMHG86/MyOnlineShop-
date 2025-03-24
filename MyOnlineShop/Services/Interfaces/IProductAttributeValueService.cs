using System.Collections.Generic;
using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IProductAttributeValueService
    {
        ProductAttributeValue GetProductAttributeValueById(int productAttributeValueId);
        List<ProductAttributeValue> GetAllProductAttributeValues();
        List<ProductAttributeValue> GetProductAttributeValuesByProductId(int productId);
        List<ProductAttributeValue> GetProductAttributeValuesByAttributeId(int productAttributeId);
        void AddProductAttributeValue(ProductAttributeValue productAttributeValue);
        void UpdateProductAttributeValue(ProductAttributeValue productAttributeValue);
        void DeleteProductAttributeValue(int productAttributeValueId);
    }
}
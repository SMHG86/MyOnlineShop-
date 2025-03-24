using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IProductAttributeService
    {
        ProductAttribute GetProductAttributeById(int productAttributeId);
        List<ProductAttribute> GetAllProductAttributes();
        ProductAttribute GetProductAttributeByName(string name);
        void AddProductAttribute(ProductAttribute productAttribute);
        void UpdateProductAttribute(ProductAttribute productAttribute);
        void DeleteProductAttribute(int productAttributeId);
    }
}
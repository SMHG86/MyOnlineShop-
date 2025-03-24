using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Data.Repositories
{
    public interface IProductAttributeRepository
    {
        ProductAttribute GetProductAttributeById(int productAttributeId);
        List<ProductAttribute> GetAllProductAttributes();
        ProductAttribute GetProductAttributeByName(string name); // پیدا کردن ویژگی محصول بر اساس نام

        void AddProductAttribute(ProductAttribute productAttribute);
        void UpdateProductAttribute(ProductAttribute productAttribute);
        void DeleteProductAttribute(int productAttributeId);
    }
}
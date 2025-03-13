using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories
{
    public interface IShippingMethodRepository
    {
        ShippingMethod GetShippingMethodById(int shippingMethodId);
        List<ShippingMethod> GetAllShippingMethods();
        ShippingMethod GetShippingMethodByName(string name); // پیدا کردن روش حمل و نقل بر اساس نام

        void AddShippingMethod(ShippingMethod shippingMethod);
        void UpdateShippingMethod(ShippingMethod shippingMethod);
        void DeleteShippingMethod(int shippingMethodId);
    }
}
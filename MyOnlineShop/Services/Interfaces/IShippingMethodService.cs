using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IShippingMethodService
    {
        ShippingMethod GetShippingMethodById(int shippingMethodId);
        List<ShippingMethod> GetAllShippingMethods();
        ShippingMethod GetShippingMethodByName(string name);
        void AddShippingMethod(ShippingMethod shippingMethod);
        void UpdateShippingMethod(ShippingMethod shippingMethod);
        void DeleteShippingMethod(int shippingMethodId);
    }
}
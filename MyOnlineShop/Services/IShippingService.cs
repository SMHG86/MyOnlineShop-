using System.Collections.Generic;
using MyOnlineShop.ViewModels; // فرض بر وجود فضای نام ViewModels

namespace MyOnlineShop.Services
{
    public interface IShippingService
    {
        ShippingMethodViewModel GetShippingMethodById(int shippingMethodId);
        List<ShippingMethodViewModel> GetAllShippingMethods();
        decimal CalculateShippingCost(ShoppingCartViewModel cart, AddressViewModel shippingAddress, ShippingMethodViewModel shippingMethod); // محاسبه هزینه حمل و نقل
    }
}
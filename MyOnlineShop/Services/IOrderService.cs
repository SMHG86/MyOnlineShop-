using MyOnlineShop.ViewModels;

namespace MyOnlineShop.Services
{
    public interface IOrderService
    {
        OrderViewModel GetOrderById(int orderId);
        List<OrderViewModel> GetOrderHistoryForCustomer(int customerId);
        OrderViewModel PlaceOrder(ShoppingCartViewModel shoppingCart, AddressViewModel shippingAddress, AddressViewModel billingAddress, PaymentMethodViewModel paymentMethod, ShippingMethodViewModel shippingMethod, int customerId);
        void UpdateOrderStatus(int orderId, string newStatus); // برای پنل مدیریت
    }
}

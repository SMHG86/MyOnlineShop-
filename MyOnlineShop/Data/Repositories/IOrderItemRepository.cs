using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories
{
    public interface IOrderItemRepository
    {
        OrderItem GetOrderItemById(int orderItemId);
        List<OrderItem> GetAllOrderItems(); // برای پنل مدیریت - لیست کامل آیتم های سفارش
        List<OrderItem> GetOrderItemsByOrderId(int orderId);

        void AddOrderItem(OrderItem orderItem);
        void UpdateOrderItem(OrderItem orderItem);
        void DeleteOrderItem(int orderItemId);
    }
}
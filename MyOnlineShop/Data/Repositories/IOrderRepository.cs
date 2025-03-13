using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories
{
    public interface IOrderRepository
    {
        Order GetOrderById(int orderId);
        List<Order> GetAllOrders(); // برای پنل مدیریت - لیست کامل سفارشات
        List<Order> GetOrderHistoryForCustomer(int customerId);

        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
        void UpdateOrderStatus(int orderId, string newStatus); // برای پنل مدیریت
    }
}
using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IOrderService
    {
        Order GetOrderById(int orderId);
        List<Order> GetAllOrders();
        List<Order> GetOrderHistoryForCustomer(int customerId);

        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
        void UpdateOrderStatus(int orderId, string newStatus);
    }
}
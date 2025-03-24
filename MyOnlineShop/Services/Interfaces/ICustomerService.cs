using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Services.Interfaces
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int customerId);
        List<Customer> GetAllCustomers();
        Customer GetCustomerByEmail(string email);

        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerId);
    }
}
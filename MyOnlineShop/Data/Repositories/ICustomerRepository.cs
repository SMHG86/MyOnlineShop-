using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int customerId);
        List<Customer> GetAllCustomers(); // برای پنل مدیریت - لیست کامل مشتریان
        Customer GetCustomerByEmail(string email); // پیدا کردن مشتری بر اساس ایمیل

        void AddCustomer(Customer customer); // برای ثبت نام مشتری جدید - احتمالا در سرویس سطح بالاتر انجام شود
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerId);
    }
}
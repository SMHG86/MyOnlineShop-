using System.Collections.Generic;
using MyOnlineShop.ViewModels;
using MyOnlineShop.ViewModels.Admin;

namespace MyOnlineShop.Services
{
    public interface ICustomerService
    {
        CustomerViewModel GetCustomerById(int customerId);
        List<CustomerAdminViewModel> GetAllCustomers(); // برای پنل مدیریت

        void UpdateCustomer(int customerId, CustomerAdminViewModel model); // برای پنل مدیریت
        void ManageCustomerRoles(int customerId, List<int> roleIds); // برای پنل مدیریت
    }
}

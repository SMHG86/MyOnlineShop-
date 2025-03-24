using System.Collections.Generic;
using System.Data;
using MyOnlineShop.Data.Entities;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IRoleService
    {
        Role GetRoleById(int roleId);
        List<Role> GetAllRoles();
        Role GetRoleByName(string roleName);
        void AddRole(Role role);
        void UpdateRole(Role role);
        void DeleteRole(int roleId);
    }
}
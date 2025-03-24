using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IAddressService
    {
        Address GetAddressById(int addressId);
        List<Address> GetAllAddresses();
        void AddAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddress(int addressId);
    }
}
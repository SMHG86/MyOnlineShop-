using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IManufacturerService
    {
        Manufacturer GetManufacturerById(int manufacturerId);
        List<Manufacturer> GetAllManufacturers();
        Manufacturer GetManufacturerByName(string name);
        void AddManufacturer(Manufacturer manufacturer);
        void UpdateManufacturer(Manufacturer manufacturer);
        void DeleteManufacturer(int manufacturerId);
    }
}
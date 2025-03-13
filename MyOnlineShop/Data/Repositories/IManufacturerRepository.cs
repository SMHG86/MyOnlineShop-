using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories
{
    public interface IManufacturerRepository
    {
        Manufacturer GetManufacturerById(int manufacturerId);
        List<Manufacturer> GetAllManufacturers();
        Manufacturer GetManufacturerByName(string name); // پیدا کردن تولید کننده بر اساس نام

        void AddManufacturer(Manufacturer manufacturer);
        void UpdateManufacturer(Manufacturer manufacturer);
        void DeleteManufacturer(int manufacturerId);
    }
}
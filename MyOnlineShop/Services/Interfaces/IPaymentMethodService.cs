using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Services.Interfaces
{
    public interface IPaymentMethodService
    {
        PaymentMethod GetPaymentMethodById(int paymentMethodId);
        List<PaymentMethod> GetAllPaymentMethods();
        PaymentMethod GetPaymentMethodByName(string name);
        void AddPaymentMethod(PaymentMethod paymentMethod);
        void UpdatePaymentMethod(PaymentMethod paymentMethod);
        void DeletePaymentMethod(int paymentMethodId);
    }
}
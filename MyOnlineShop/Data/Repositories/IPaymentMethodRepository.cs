using System.Collections.Generic;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories
{
    public interface IPaymentMethodRepository
    {
        PaymentMethod GetPaymentMethodById(int paymentMethodId);
        List<PaymentMethod> GetAllPaymentMethods();
        PaymentMethod GetPaymentMethodByName(string name); // پیدا کردن روش پرداخت بر اساس نام

        void AddPaymentMethod(PaymentMethod paymentMethod);
        void UpdatePaymentMethod(PaymentMethod paymentMethod);
        void DeletePaymentMethod(int paymentMethodId);
    }
}
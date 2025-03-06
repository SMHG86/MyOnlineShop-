using MyOnlineShop.ViewModels;
using System.Collections.Generic;

namespace MyOnlineShop.Services
{
    public interface IPaymentService
    {
        PaymentMethodViewModel GetPaymentMethodById(int paymentMethodId);
        List<PaymentMethodViewModel> GetAllPaymentMethods();
    }
}

using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Data.Entities;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data.Repositories.Implementations
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        private readonly ApplicationDbContext _context;

        public PaymentMethodRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public PaymentMethod GetPaymentMethodById(int paymentMethodId)
        {
            return _context.PaymentMethods.Find(paymentMethodId);
        }

        public List<PaymentMethod> GetAllPaymentMethods()
        {
            return _context.PaymentMethods.ToList();
        }

        public PaymentMethod GetPaymentMethodByName(string name)
        {
            return _context.PaymentMethods.FirstOrDefault(pm => pm.Name == name);
        }

        public void AddPaymentMethod(PaymentMethod paymentMethod)
        {
            _context.PaymentMethods.Add(paymentMethod);
            _context.SaveChanges();
        }

        public void UpdatePaymentMethod(PaymentMethod paymentMethod)
        {
            _context.PaymentMethods.Update(paymentMethod);
            _context.SaveChanges();
        }

        public void DeletePaymentMethod(int paymentMethodId)
        {
            var paymentMethod = _context.PaymentMethods.Find(paymentMethodId);
            if (paymentMethod != null)
            {
                _context.PaymentMethods.Remove(paymentMethod);
                _context.SaveChanges();
            }
        }
    }
}
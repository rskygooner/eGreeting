using eGreeting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Services
{
    public interface IPaymentServices
    {
        List<PaymentInfo> GetPayments();
        PaymentInfo GetPayment(int id);
        PaymentInfo GetPaymentByUsername(string username);
        bool CreatePayment(PaymentInfo payment);
        bool EditPayment(PaymentInfo payment);
        bool DeletePayment(int id);
        bool ChangeStatusActivation(int id, bool check);
    }
    public class PaymentServices : IPaymentServices
    {
        private readonly MariaDBContext _dbContext;
        public PaymentServices(MariaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<PaymentInfo> GetPayments()
        {
            List<PaymentInfo> paymentInfos = _dbContext.PaymentInfos.ToList();
            return paymentInfos;
        }

        public PaymentInfo GetPayment(int id)
        {
            PaymentInfo paymentInfo = _dbContext.PaymentInfos.Find(id);
            return paymentInfo;
        }

        public PaymentInfo GetPaymentByUsername(string username)
        {
            PaymentInfo paymentInfo = _dbContext.PaymentInfos.FirstOrDefault(item => item.UserName == username);
            return paymentInfo;
        }

        public bool CreatePayment(PaymentInfo payment)
        {
            var b = GetPayment(payment.PayId);
            if (b == null)
            {
                _dbContext.PaymentInfos.Add(payment);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EditPayment(PaymentInfo payment)
        {
            var b = GetPayment(payment.PayId);
            if (b != null)
            {
                b.BankAccount = payment.BankAccount;
                b.BankName = payment.BankName;
                b.DateExpire = payment.DateExpire;
                b.IsActive = payment.IsActive;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }


        public bool DeletePayment(int id)
        {
            var b = GetPayment(id);
            if (b != null)
            {
                _dbContext.PaymentInfos.Remove(b);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ChangeStatusActivation(int id, bool check)
        {
            var search = GetPayment(id);
            if (search != null)
            {
                if (!check)
                {
                    search.IsActive = Status.Inactive;
                }
                else
                {
                    search.IsActive = Status.Active;
                    search.DateCreated = DateTime.Now;
                }
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

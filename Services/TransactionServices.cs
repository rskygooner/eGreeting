using eGreeting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Services
{
    public interface ITransactionServices
    {
        List<Transaction> GetTransactions();
        Transaction GetTransaction(int id);
        bool CreateTransaction(Transaction transaction);
        bool DeleteTransaction(int id);
    }
    public class TransactionServices : ITransactionServices
    {
        private readonly MariaDBContext _dbContext;

        public TransactionServices(MariaDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = _dbContext.Transactions.ToList();
            return transactions;
        }

        public Transaction GetTransaction(int id)
        {
            Transaction transaction = _dbContext.Transactions.Find(id);
            return transaction;
        }

        public bool CreateTransaction(Transaction transaction)
        {
            var b = GetTransaction(transaction.TransId);
            if (b == null)
            {
                _dbContext.Transactions.Add(transaction);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteTransaction(int id)
        {
            var b = GetTransaction(id);
            if (b != null)
            {
                _dbContext.Transactions.Remove(b);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

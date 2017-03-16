using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class TransactionRepository
    {
        internal Transaction Create()
        {
            Transaction transaction = new Transaction
            {
                Date = DateTime.Now
            };
            return transaction;
        }

        internal List<Transaction> Retrieve()
        {
            List<Transaction> transactions = new List<Transaction>();
            return transactions;
        }

        internal Transaction Save(Transaction transaction)
        {
            return transaction;
        }
    }
}
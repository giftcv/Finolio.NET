using System.Collections.Generic;
using Finolio.Models;

namespace Finolio.Services
{
    public interface ITransactionService
    {
        IEnumerable<Transaction> GetTransactions();
        IEnumerable<Transaction> GetCategoryTransactions(string categoryName, string transactionName = null);
        Transaction GetTransaction(int id);
        void CreateTransaction(Transaction transaction);
        void SaveTransaction();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finolio.DataAccess.Repositories;
using Finolio.DataAccess.Infrastructure;
using Finolio.Models;

namespace Finolio.Services
{
    public class TransactionService:ITransactionService
    {
        private readonly ITransactionRepository transactionRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public TransactionService(ITransactionRepository transactionRepository, ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this.transactionRepository = transactionRepository;
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            var transactions = transactionRepository.GetAll();
            return transactions;
        }

        public IEnumerable<Transaction> GetCategoryTransactions(string categoryName, string transactionName = null)
        {
            var category = categoryRepository.GetCategoryByName(categoryName);
            return category.Transactions.Where(g => g.Description.ToLower().Contains(transactionName.ToLower().Trim()));
        }

        public Transaction GetTransaction(int id)
        {
            var transaction = transactionRepository.GetById(id);
            return transaction;
        }

        public void CreateTransaction(Transaction transaction)
        {
            transactionRepository.Add(transaction);
        }

        public void SaveTransaction()
        {
            unitOfWork.Commit();
        }
    }
}

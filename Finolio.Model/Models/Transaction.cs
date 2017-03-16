using System;

namespace Finolio.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
    }
}
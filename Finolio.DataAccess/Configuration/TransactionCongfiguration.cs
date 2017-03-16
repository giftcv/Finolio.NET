using System.Data.Entity.ModelConfiguration;
using Finolio.Models;

namespace Finolio.DataAccess.Configuration
{
    public class TransactionConfiguration : EntityTypeConfiguration<Transaction>
    {
        public TransactionConfiguration()
        {
            ToTable("Transactions");
            Property(t => t.Description).IsRequired().HasMaxLength(50);
            Property(t => t.Amount).IsRequired().HasPrecision(8, 2);
            Property(t => t.CategoryID).IsRequired();
        }
    }
}

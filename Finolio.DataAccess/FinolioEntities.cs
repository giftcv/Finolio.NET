using System.Data.Entity;
using Finolio.Models;
using Finolio.DataAccess.Configuration;

namespace Finolio.DataAccess
{
    public class FinolioEntities : DbContext
    {
        public FinolioEntities() : base("FinolioEntities") { }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TransactionConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finolio.Models
{
    public class Category
    {

        public int CategoryID { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual List<Transaction> Transactions { get; set; }

        public Category()
        {
            DateCreated = DateTime.Now;
        }

    }
}

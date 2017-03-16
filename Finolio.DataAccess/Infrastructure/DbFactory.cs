using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finolio.DataAccess.Infrastructure
{
    public class DbFactory:Disposable,IDbFactory
    {
        FinolioEntities dbContext;

        public FinolioEntities Init()
        {
            return dbContext ?? (dbContext = new FinolioEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}

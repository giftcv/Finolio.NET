using System;

namespace Finolio.DataAccess.Infrastructure
{
    public interface IDbFactory: IDisposable
    {
        FinolioEntities Init();
    }
}

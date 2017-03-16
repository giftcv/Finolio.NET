using Finolio.DataAccess.Infrastructure;
using Finolio.Models;

namespace Finolio.DataAccess.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByName(string categoryName);
    }
}

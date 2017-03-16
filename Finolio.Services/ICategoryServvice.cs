using System.Collections.Generic;
using Finolio.Models;

namespace Finolio.Services
{
    public interface ICategoryServvice
    {
        IEnumerable<Category> GetCategories(string name = null);
        Category GetCategory(int id);
        Category GetCategory(string name);
        void CreateCategory(Category category);
        void SaveCategory();
    }
}

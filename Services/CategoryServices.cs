using eGreeting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Services
{
    public interface ICategoryServices
    {
        IEnumerable<Category> GetCategories();
    }
    public class CategoryServices : ICategoryServices
    {
        private readonly MariaDBContext _dbContext;

        public CategoryServices(MariaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Category> GetCategories()
        {
            IEnumerable<Category> categories = _dbContext.Categories.ToList();
            return categories;
        }
    }
}

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
        Category GetCategory(int id);
        bool CreateCategory(Category category);
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
        public Category GetCategory(int id)
        {
            Category category = _dbContext.Categories.Find(id);
            return category;
        }
        public bool CreateCategory(Category category)
        {
            try
            {
                _dbContext.Categories.Add(category);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditCategory(Category category)
        {
            try
            {
                _dbContext.Categories.Update(category);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

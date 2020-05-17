using eGreeting.Models;
using Microsoft.CodeAnalysis.Differencing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Services
{
    public interface ICategoryServices
    {
        List<Category> GetCategories();
        Category GetCategory(int id);
        bool CreateCategory(Category category);
        bool EditCategory(Category category);
        bool DeleteCategory(int id);
    }
    public class CategoryServices : ICategoryServices
    {
        private readonly MariaDBContext _dbContext;

        public CategoryServices(MariaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = _dbContext.Categories.ToList();
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
                var cate = _dbContext.Categories.Find(category.CategoryId);
                cate.CategoryName = category.CategoryName;
                cate.IsActive = category.IsActive;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteCategory(int id)
        {
            try
            {
                var cate = _dbContext.Categories.Find(id);
                _dbContext.Remove(cate);
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

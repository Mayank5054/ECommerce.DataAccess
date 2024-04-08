using ECommerce.DataAccess.Data;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Repository.IRepository
{
    internal class CategoryRepository : ICategoryRepository
    {
        readonly ApplicationDbContext _db;
        CategoryRepository(ApplicationDbContext db) {
            _db = db;
        }
        public void deleteCategory(int id)
        {
            var status = _db.Categories.Find(id);
            if(status != null)
            {
                _db.Categories.Remove(status);
                _db.SaveChanges();
            }

        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _db.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            var status = _db.Categories.Find(id);
            if(status != null) {
                return status;
            }
            else
            {
                return null;
            }
        }

        public void saveCategory(Category cat)
        {
            _db.Categories.Add(cat);
            _db.SaveChanges();
        }

        public void updateCategory(Category category)
        {
            var status = _db.Categories.Find(category.CategoryId);
            if(status != null) { 
            _db.Categories.Update(category);
                _db.SaveChanges();
            }
        }
    }
}

using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Repository.IRepository
{
    internal interface ICategoryRepository
    {
        void saveCategory(Category cat);
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void deleteCategory(int id);
        void updateCategory(Category category);
    }
}

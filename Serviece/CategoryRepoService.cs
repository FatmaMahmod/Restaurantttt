using Microsoft.EntityFrameworkCore;
using Yummy.Data;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Serviece
{
    public class CategoryRepoService : ICategory
    {

        public ApplicationDbContext _context;

        public CategoryRepoService(ApplicationDbContext context)
        {
            _context = context;
        } 
        public List<Category> GetAllCategory()
        {
            return _context.Categories.Include(op=>op.Meals).ToList();
        }

     

        public Category GetCategoryDetails(int id)
        {
            // Implement logic to get category details by ID
            return _context.Categories.Include(op => op.Meals).Where(op=>op.ID==id).FirstOrDefault();
        }

        public void InsertCategory(Category category)
        {
            if (category != null)
            {
                // Implement logic to insert a new category
                _context.Categories.Add(category);
                _context.SaveChanges();
            }
        }

        public void UpdateCategory(int id, Category updatedCategory)
        {
            Category existingCategory = _context.Categories.Include(op => op.Meals).Where(op => op.ID == id).FirstOrDefault();
            if (existingCategory != null)
            {
                // Implement logic to update an existing category
                existingCategory.CategoryName = updatedCategory.CategoryName;
                // Update other properties as needed
                _context.SaveChanges();
            }
        }

        public void DeleteCategory(int id)
        {
            Category categoryToDelete = _context.Categories.Include(op => op.Meals).Where(op => op.ID == id).FirstOrDefault();
            if (categoryToDelete != null)
            {
                // Implement logic to delete a category
                _context.Categories.Remove(categoryToDelete);
                _context.SaveChanges();
            }
        }

      
    }
}

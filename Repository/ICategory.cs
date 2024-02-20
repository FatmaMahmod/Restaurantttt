using YUMMY.Models;

namespace Yummy.Repository
{
    public interface ICategory
    {
        public List<Category> GetAllCategory();
        public Category GetCategoryDetails(int id);
        public void InsertCategory(Category category);
        public void UpdateCategory(int id, Category Category);
        public void DeleteCategory(int id);

    }
}

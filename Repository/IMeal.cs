using YUMMY.Models;

namespace Yummy.Repository
{
    public interface IMeal
    {
        public List<Meal> GetAllMeal();
        public Meal GetMealDetails(int id);
        public void InsertMeal(Meal Meal);
        public void UpdateMeal(int id, Meal Meal);
        public void DeleteMeal(int id);
    }
}

using Microsoft.EntityFrameworkCore;
using Yummy.Data;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Serviece
{
    public class MealRepoService : IMeal
    {
        public ApplicationDbContext _context;

        public MealRepoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Meal> GetAllMeal()
        {
            //List<Meal>me=_context.Meals.ToList();
            // Placeholder logic to get all meals
            return _context.Meals.Include(op => op.Category).ToList();
            //return _context.Meals.ToList();
            //return me;
        }

        public Meal GetMealDetails(int id)
        {
            // Placeholder logic to get meal details by ID
            return _context.Meals.Include(op => op.Category).Where(op=>op.ID==id).FirstOrDefault();
        }

        public void InsertMeal(Meal newMeal)
        {
            // Placeholder logic to insert a new meal
            _context.Meals.Add(newMeal);
            _context.SaveChanges();
        }

        public void UpdateMeal(int id, Meal updatedMeal)
        {
            Meal existingMeal = _context.Meals.Include(op => op.Category).Where(op => op.ID == id).FirstOrDefault();
            if (existingMeal != null)
            {
                // Placeholder logic to update an existing meal
                existingMeal.MealName = updatedMeal.MealName;
                existingMeal.MealRating = updatedMeal.MealRating;
                existingMeal.MealIngradints = updatedMeal.MealIngradints;
                existingMeal.MealImage = updatedMeal.MealImage;
                _context.SaveChanges();
            }
        }

        public void DeleteMeal(int id)
        {
            Meal mealToDelete = _context.Meals.Include(op => op.Category).Where(op => op.ID == id).FirstOrDefault();
            if (mealToDelete != null)
            {
                // Placeholder logic to delete a meal
                _context.Meals.Remove(mealToDelete);
                _context.SaveChanges();
            }
        }
    }
}

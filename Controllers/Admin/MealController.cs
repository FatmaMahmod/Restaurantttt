using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Repository;
using Yummy.Serviece;
using YUMMY.Models;

namespace Yummy.Controllers.Admin
{
    public class MealController : Controller
    {
        public ICategory Category { get; set; }
        public IMeal Meal { get; set; }
        public IReview Review { get; set; }
        public MealController(ICategory category, IMeal meal, IReview review)
        {
            Category = category;

            Meal = meal;
            Review = review;
        }
        //Meals
        // GET: AdminController
        public ActionResult AllMeals()
        {
            return View(Meal.GetAllMeal());
        }

        // GET: AdminController/Details/5
        public ActionResult MealDetails(int id)
        {
            return View(Meal.GetMealDetails(id));
        }

        // GET: AdminController/Create
        public ActionResult MealCreate()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MealCreate(Meal meal)
        {

            if (ModelState.IsValid)
            {
                Meal.InsertMeal(meal);
                return RedirectToAction(nameof(AllMeals));
            }
            return View(meal);

        }

        // GET: AdminController/Edit/5
        public ActionResult MealEdit(int id)
        {
            return View(Meal.GetMealDetails(id));
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MealEdit(int id, Meal meal)
        {
            if (ModelState.IsValid)
            {
                Meal.UpdateMeal(id, meal);
                return RedirectToAction(nameof(AllMeals));
            }
            return View(meal);
        }

        // GET: AdminController/Delete/5
        public ActionResult MealDelete(int id)
        {
            return View(Meal.GetMealDetails(id));
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MealDelete(int id, Meal meal)
        {
            if (ModelState.IsValid)
            {
                Meal.DeleteMeal(id);
                return RedirectToAction(nameof(AllMeals));
            }
            return View(meal);

        }
        
    }
}

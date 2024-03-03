using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YUMMY.Models;
using Yummy.Data;
using Yummy.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Yummy.Controllers.User
{
    public class MealsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MealsController(ApplicationDbContext context)
        {
            _context = context;
        }



        // GET: Meals
        public async Task<IActionResult> getAllMeals()
        {
            var applicationDbContext = _context.Meals.Include(m => m.Category);
            return View(await applicationDbContext.ToListAsync());
        }




        //public async Task<IActionResult> MenuItems(string categoryName)
        //{
        //    if (string.IsNullOrEmpty(categoryName))
        //    {
        //        // Handle case where category name is not provided
        //        return RedirectToAction("getSixMeals");
        //    }

        //    // Retrieve the meals for the specified category from your data source
        //    var meals = await _context.Meals
        //        .Include(m => m.Category)
        //        .Where(m => m.Category.CategoryName == categoryName)
        //        .ToListAsync();

        //    if (meals == null || meals.Count == 0)
        //    {
        //        return NotFound(); // Return 404 if no meals are found for the category
        //    }

        //    return View(meals);
        //}




        public async Task<IActionResult> MenuItems(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
            {
                // Handle case where category name is not provided
                return RedirectToAction("getSixMeals");
            }

            // Retrieve the meals for the specified category from your data source
            var meals = await _context.Meals
                .Include(m => m.Category)
                .Where(m => m.Category.CategoryName == categoryName)
                .ToListAsync();

            if (meals == null || meals.Count == 0)
            {
                return NotFound(); // Return 404 if no meals are found for the category
            }

            ViewBag.CategoryName = categoryName; // Set the category name in ViewBag

            return View(meals);
        }









        //public async Task<IActionResult> getSixMeals(string categoryName)
        //{
        //    // Filter meals by category and select only the first six items
        //    var mealsForCategory = await _context.Meals
        //        .Include(m => m.Category)
        //        .Where(m => m.Category.CategoryName == categoryName)
        //        .OrderBy(m => m.ID)
        //        .Take(6)
        //        .ToListAsync();

        //    return View(mealsForCategory);
        //}





        //public ActionResult Index()
        //{
        //    return View(Meal.GetAllMeal());
        //}


        // GET: Meals
        //public async Task<IActionResult> GetSixMeals()
        //{
        //    // Get all categories
        //    var categories = await _context.Categories.ToListAsync();

        //    // Create a list to store the selected meals
        //    var selectedMeals = new List<Meal>();

        //    // Iterate over each category
        //    foreach (var category in categories)
        //    {
        //        // Get the first six meals for the current category
        //        var mealsForCategory = await _context.Meals
        //            .Include(m => m.Category)
        //            .Where(m => m.CategoryID == category.ID)
        //            .OrderBy(m => m.ID) // You can change the ordering as needed
        //            .Take(6)
        //            .ToListAsync();

        //        // Add the meals to the selectedMeals list
        //        selectedMeals.AddRange(mealsForCategory);
        //    }

        //    return View(selectedMeals);
        //}



        // GET: Meals/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Meals == null)
        //    {
        //        return NotFound();
        //    }

        //    var meal = await _context.Meals
        //        .Include(m => m.Category)
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (meal == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(meal);
        //}

        public async Task<IActionResult> Details(int? id)
        {
            var mealFromDB = _context.Meals.Include(x => x.Category)
                .Where(x => x.ID == id)
                .FirstOrDefault();

            if (mealFromDB == null)
            {
                return NotFound();
            }

            var cart = new cart
            {
                Meal = mealFromDB,
                MealId = mealFromDB.ID,
                Count = 1,
            };

            return View(cart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Details([Bind("MealId, Count")] cart cart)
        {
            if (ModelState.IsValid)
            {
                var claimIdentity = (ClaimsIdentity)this.User.Identity;
                var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
                cart.ApplicationUserId = claim.Value;

                var cartfromDB = await _context.carts.Include(x=>x.Meal)
                    .Where(x => x.ApplicationUserId == cart.ApplicationUserId && x.MealId == cart.MealId)
                    .FirstOrDefaultAsync();
                var meal = _context.Meals.Include(x=>x.Category).Where(x => x.ID==cart.MealId).FirstOrDefault();
              //  var catname = ;
                if (cartfromDB == null)
                {
                    _context.carts.Add(cart);
                }
                else
                {
                    cartfromDB.Count += cart.Count;
                }

                _context.SaveChanges();
                //var catname = cart
                return RedirectToAction("MenuItems", new { categoryName = meal.Category.CategoryName });
            }
            
            return RedirectToAction("MenuItems");
        }

    }
}


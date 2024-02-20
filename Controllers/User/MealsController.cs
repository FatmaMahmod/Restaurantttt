using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YUMMY.Models;
using Yummy.Data;

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
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Meals.Include(m => m.Category);
            return View(await applicationDbContext.ToListAsync());
        }


        // GET: Meals
        public async Task<IActionResult> getSixMeals()
        {
            var meals = await _context.Meals
                .Include(m => m.Category)
                .Take(6) // Retrieve only six meals
                .ToListAsync();

            return View(meals);
        }

        // GET: Meals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Meals == null)
            {
                return NotFound();
            }

            var meal = await _context.Meals
                .Include(m => m.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meal == null)
            {
                return NotFound();
            }

            return View(meal);
        }

        
    }
}

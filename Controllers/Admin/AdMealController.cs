using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Controllers.Admin
{
    public class AdMealController : Controller
    {
        public ICategory Category { get; }
        public IMeal Meal { get; }

        public IWebHostEnvironment Host;
        public AdMealController(IMeal meal,ICategory category,IWebHostEnvironment host)
        {
            Meal = meal;
            Category = category;
            Host = host;
        }
        // GET: AdMealController
        public ActionResult Index()
        {
            if (ModelState.IsValid)
            {
                return View(Meal.GetAllMeal());
            }
            return View();
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View(Meal.GetMealDetails(id));
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            ViewBag.allcategory = Category.GetAllCategory();
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Meal meal)
        {
            ViewBag.allcategory = Category.GetAllCategory();
            if (ModelState.IsValid)
            {
                if (meal != null && meal.ImageFile != null)
                {
                    string wwwRootPath = Host.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(meal.ImageFile.FileName);
                    string extension = Path.GetExtension(meal.ImageFile.FileName);
                    string uniqueFileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string imagePath = Path.Combine(wwwRootPath, "images", uniqueFileName);
                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        meal.ImageFile.CopyTo(fileStream);
                    }
                    meal.MealImage = uniqueFileName;
                }
                Meal.InsertMeal(meal);
                return RedirectToAction(nameof(Index));
            }
            return View(meal);
        }
        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.allcategory = Category.GetAllCategory();
            return View(Meal.GetMealDetails(id));
        }
        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Meal meal)
        {
            ViewBag.allcategory = Category.GetAllCategory();
            if (ModelState.IsValid)
            {
                var data = Meal.GetMealDetails(id);
                string uniquFileName = string.Empty;
                if (meal.ImageFile != null)
                {
                    if (data.MealImage != null)
                    {
                        string wwwRootPath = Host.WebRootPath;
                        string filePath = Path.Combine(wwwRootPath, "images", data.MealImage);
                        if (System.IO.File.Exists(filePath))
                        {
                            System.IO.File.Delete(filePath);
                        }
                    }
                }
                if (meal != null)
                {
                    string wwwRootPath = Host.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(meal.ImageFile.FileName);
                    string extension = Path.GetExtension(meal.ImageFile.FileName);
                    string uniqueFileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string imagePath = Path.Combine(wwwRootPath, "images", uniqueFileName);
                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        meal.ImageFile.CopyTo(fileStream);
                    }
                    meal.MealImage = uniqueFileName;
                }
                ///////
                Meal.UpdateMeal(id, meal);
                return RedirectToAction(nameof(Index));
            }
            return View(meal);
        }
        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Meal.GetMealDetails(id));
        }
        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Meal meal)
        {
            Meal.DeleteMeal(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

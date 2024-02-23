using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Controllers.Admin
{
    [Authorize(Roles = "Admin")]
    public class AdCategoryController : Controller
    {
        public ICategory Category { get; set; }
        public AdCategoryController(ICategory category)
        {
            Category = category;
        }
        // GET: AdCategoryController
        public ActionResult Index()
        {
            return View(Category.GetAllCategory());
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View(Category.GetCategoryDetails(id));
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {

            if (ModelState.IsValid)
            {
                Category.InsertCategory(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);

        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Category.GetCategoryDetails(id));
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            if (ModelState.IsValid)
            {
                Category.UpdateCategory(id, category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Category.GetCategoryDetails(id));
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category category)
        {
            if (ModelState.IsValid)
            {
                Category.DeleteCategory(id);
                return RedirectToAction(nameof(Index));
            }
            return View(category);

        }
    }
}

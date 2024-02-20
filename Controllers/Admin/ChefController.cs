using Microsoft.AspNetCore.Mvc;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Controllers.Admin
{
    public class ChefController : Controller
    {
        public IChef Chef { get; set; }
        public ChefController(IChef chef)
        {
            Chef = chef;
        }
        public ActionResult AllChefs()
        {
            return View(Chef.GetAllChef());
        }

        // GET: AdminController/Details/5
        public ActionResult ChefDetails(int id)
        {
            return View(Chef.GetChefDetails(id));
        }

        // GET: AdminController/Create
        public ActionResult ChefCreate()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChefCreate(Chef chef)
        {

            if (ModelState.IsValid)
            {
                Chef.InsertChef(chef);
                return RedirectToAction(nameof(AllChefs));
            }
            return View(chef);

        }

        // GET: AdminController/Edit/5
        public ActionResult ChefEdit(int id)
        {
            return View(Chef.GetChefDetails(id));
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChefEdit(int id, Chef chef)
        {
            if (ModelState.IsValid)
            {
                Chef.UpdateChef(id, chef);
                return RedirectToAction(nameof(AllChefs));
            }
            return View(chef);
        }

        // GET: AdminController/Delete/5
        public ActionResult ChefDelete(int id)
        {
            return View(Chef.GetChefDetails(id));
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChefDelete(int id, Chef chef)
        {
            if (ModelState.IsValid)
            {
                Chef.DeleteChef(id);
                return RedirectToAction(nameof(AllChefs));
            }
            return View(chef);

        }
    }
}

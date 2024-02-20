using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Controllers.Admin
{
    public class AdChefController : Controller
    {
        public IChef Chef { get; set; }
        public IWebHostEnvironment Host;
        public AdChefController(IChef chef,IWebHostEnvironment host)
        {
            Chef = chef;
            Host = host;
        }
        // GET: AdChefController
        public ActionResult Index()
        {
            return View(Chef.GetAllChef());
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View(Chef.GetChefDetails(id));
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Chef chef)
        {

            if (ModelState.IsValid)
            {
                if (chef != null && chef.ImageFile != null)
                {
                    string wwwRootPath = Host.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(chef.ImageFile.FileName);
                    string extension = Path.GetExtension(chef.ImageFile.FileName);
                    string uniqueFileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string imagePath = Path.Combine(wwwRootPath, "images", uniqueFileName);
                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        chef.ImageFile.CopyTo(fileStream);
                    }
                    chef.Image = uniqueFileName;
                }
                //
                Chef.InsertChef(chef);
                return RedirectToAction(nameof(Index));
            }
            return View(chef);

        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Chef.GetChefDetails(id));
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Chef chef)
        {
            if (ModelState.IsValid)
            {
                var data = Chef.GetChefDetails(id);
                string uniquFileName = string.Empty;
                if (chef.ImageFile != null)
                {
                    if (data.Image != null)
                    {
                        string wwwRootPath = Host.WebRootPath;
                        string filePath = Path.Combine(wwwRootPath, "images", data.Image);
                        if (System.IO.File.Exists(filePath))
                        {
                            System.IO.File.Delete(filePath);
                        }
                    }
                }
                if (chef != null)
                {
                    string wwwRootPath = Host.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(chef.ImageFile.FileName);
                    string extension = Path.GetExtension(chef.ImageFile.FileName);
                    string uniqueFileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string imagePath = Path.Combine(wwwRootPath, "images", uniqueFileName);
                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        chef.ImageFile.CopyTo(fileStream);
                    }
                    chef.Image = uniqueFileName;
                }
                Chef.UpdateChef(id, chef);
                return RedirectToAction(nameof(Index));
            }
            return View(chef);
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Chef.GetChefDetails(id));
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Chef chef)
        {
            Chef.DeleteChef(id);
            return RedirectToAction(nameof(Index));

        }
    }
}


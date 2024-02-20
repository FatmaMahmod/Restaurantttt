using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Controllers.Admin
{
    public class AdEventController : Controller
    {
        public IEvent @event { get; set; }
        public IWebHostEnvironment Host;
        public AdEventController(IEvent _event,IWebHostEnvironment host)
        {
            @event = _event;
            Host = host;
        }
        // GET: AdEventController
        public ActionResult Index()
        {
            return View(@event.GetAllEvent());
        }

        // GET: EventController/Details/5
        public ActionResult Details(int id)
        {
            return View(@event.GetEventDetails(id));
        }

        // GET: EventController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Event eve)
        {
            if (ModelState.IsValid)
            {
                if (eve != null && eve.ImageFile != null)
                {
                    string wwwRootPath = Host.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(eve.ImageFile.FileName);
                    string extension = Path.GetExtension(eve.ImageFile.FileName);
                    string uniqueFileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string imagePath = Path.Combine(wwwRootPath, "images", uniqueFileName);
                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        eve.ImageFile.CopyTo(fileStream);
                    }
                    eve.EventImage = uniqueFileName;
                }
                /////
                @event.InsertEvent(eve);
                return RedirectToAction(nameof(Index));
            }
            return View(eve);
        }

        // GET: EventController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(@event.GetEventDetails(id));
        }

        // POST: EventController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Event eve)
        {
            if (ModelState.IsValid)
            {
                var data = @event.GetEventDetails(id);
                string uniquFileName = string.Empty;
                if (eve.ImageFile != null)
                {
                    if (data.EventImage != null)
                    {
                        string wwwRootPath = Host.WebRootPath;
                        string filePath = Path.Combine(wwwRootPath, "images", data.EventImage);
                        if (System.IO.File.Exists(filePath))
                        {
                            System.IO.File.Delete(filePath);
                        }
                    }
                }
                if (eve != null)
                {
                    string wwwRootPath = Host.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(eve.ImageFile.FileName);
                    string extension = Path.GetExtension(eve.ImageFile.FileName);
                    string uniqueFileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string imagePath = Path.Combine(wwwRootPath, "images", uniqueFileName);
                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        eve.ImageFile.CopyTo(fileStream);
                    }
                    eve.EventImage = uniqueFileName;
                }
                @event.UpdateEvent(id, eve);
                return RedirectToAction(nameof(Index));
            }
            return View(eve);
        }

        // GET: EventController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(@event.GetEventDetails(id));
        }

        // POST: EventController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Event eve)
        {
            @event.DeleteEvent(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

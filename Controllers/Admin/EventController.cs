using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Controllers.Admin
{
    public class EventController : Controller
    {
        public IEvent @event { get; set; }
        public EventController(IEvent @eventt)
        {
            @event = @eventt;
        }
        // GET: EventController
        public ActionResult AllEvents()
        {
            return View(@event.GetAllEvent());
        }

        // GET: EventController/Details/5
        public ActionResult EventDetails(int id)
        {
            return View(@event.GetEventDetails(id));
        }

        // GET: EventController/Create
        public ActionResult EventCreate()
        {
            return View();
        }

        // POST: EventController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EventCreate(Event eve)
        {
            if (ModelState.IsValid)
            {
                @event.InsertEvent(eve);
                return RedirectToAction(nameof(AllEvents));
            }
            return View(eve);
        }

        // GET: EventController/Edit/5
        public ActionResult EventEdit(int id)
        {
            return View(@event.GetEventDetails(id));
        }

        // POST: EventController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EventEdit(int id, Event eve)
        {
            if (ModelState.IsValid)
            {
                @event.UpdateEvent(id, eve);
                return RedirectToAction(nameof(AllEvents));
            }
            return View(eve);
        }

        // GET: EventController/Delete/5
        public ActionResult EventDelete(int id)
        {
            return View(@event.GetEventDetails(id));
        }

        // POST: EventController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EventDelete(int id, Event eve)
        {
            if (ModelState.IsValid)
            {
                @event.DeleteEvent(id);
                return RedirectToAction(nameof(AllEvents));
            }
            return View(eve);
        }
    }
}

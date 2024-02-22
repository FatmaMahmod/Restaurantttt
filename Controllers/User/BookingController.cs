using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Yummy.Controllers.User
{
    [Authorize]
    public class BookingController : Controller
    {
        public ActionResult Book()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Book(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

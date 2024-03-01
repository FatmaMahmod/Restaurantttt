using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Yummy.Data;
using Yummy.Models;
using Yummy.Repository;

namespace Yummy.Controllers
{
    public class HomeController : Controller
    {
        public IHome home { get; set; }

        public HomeController(IHome hom)
        {
          home = hom;
        }

        public IActionResult Index()
        {
            ViewBag.chef = home.GetAllChef();
            ViewBag.events = home.GetAllEvent();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
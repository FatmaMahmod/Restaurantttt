using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Http;
=======

using Microsoft.AspNetCore.Mvc;
using Yummy.Models;
using Yummy.Repository;
using Microsoft.AspNetCore.Identity;
namespace Yummy.Controllers.Admin
{
    [Authorize]
    public class AdReviewsController : Controller
    {
        public IReview Review { get; set; }
        public AdReviewsController(IReview review)
        {
            Review = review;
        }
        // GET: AdReviewsController
        public ActionResult Index()
        {
            return View(Review.GetAllReview());
        }
        public ActionResult Create()
        {
            ViewBag.Name = User.Identity.Name;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Review review)
        {
            Review.InsertReview(review);
            return RedirectToAction(nameof(Index));
        }



    }
}

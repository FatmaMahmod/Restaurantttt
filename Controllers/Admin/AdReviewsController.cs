using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Repository;

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

       
       
    }
}

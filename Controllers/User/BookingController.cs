using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Data;
using Yummy.Models;
using Yummy.Repository;

namespace Yummy.Controllers.User
{
    //[Authorize]
    public class BookingController : Controller
    {
        private readonly IBooking _booking_table_service;
        public BookingController(IBooking booking) {
            _booking_table_service = booking;
        }
        [HttpGet]
        public ActionResult Book()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Book(Booking book_table)
        {

            if (ModelState.IsValid)
            {
                _booking_table_service.InsertBookingTables(book_table);
                return RedirectToAction("Index", "Home"); // Assuming "HomeController" is your controller name
            }
            else
            {
                return View();
            }
        }
    }
}

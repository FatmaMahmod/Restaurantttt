using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Data;
using Yummy.Models;
using Yummy.Repository;

namespace Yummy.Controllers.User
{
    [Authorize]
    public class BookingController : Controller
    {
        private readonly IBooking _booking_table_service;
        private readonly IFindUser _find_user;

        public BookingController(IBooking booking, IFindUser find_user) {
            _booking_table_service = booking;
            _find_user = find_user;
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
                book_table.userID = _find_user.GetUserId();
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

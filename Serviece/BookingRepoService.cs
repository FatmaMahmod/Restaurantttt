using System.Security.Claims;
using Yummy.Data;
using Yummy.Models;
using Yummy.Repository;
using YUMMY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace Yummy.Serviece
{
    public class BookingRepoService : IBooking
    {
       public ApplicationDbContext _context;

        public BookingRepoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Booking> GetAllBookingTables()
        {
            // Placeholder logic to get all events
            return _context.BookingTables.ToList();
        }

        public Booking GetBookingTablesDetails(int id)
        {
            // Placeholder logic to get event details by ID
            return _context.BookingTables.Find(id);
        }

        public void InsertBookingTables(Booking newBooking)
        {
            // Insert the new booking
            _context.BookingTables.Add(newBooking);
            _context.SaveChanges();
        }

        //public void InsertBookingTables(Booking newBooking)
        //{
        //    // Placeholder logic to insert a new event
        //    var claimIdentity = (ClaimsIdentity)this.User.Identity;
        //    var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

        //    //newBooking.userID= claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
        //    _context.BookingTables.Add(newBooking);
        //    _context.SaveChanges();
        //}

        public void UpdateBookingTables(int id, Booking updatedBooking)
        {
            Booking existingBooking = _context.BookingTables.Find(id);
            if (existingBooking != null)
            {
                // Placeholder logic to update an existing event
                existingBooking.Name = updatedBooking.Name;
                existingBooking.Phone = updatedBooking.Phone;
                existingBooking.Message = updatedBooking.Message;
                existingBooking.Date = updatedBooking.Date;
                _context.SaveChanges();
            }
        }

        public void DeleteBookingTables(int id)
        {
            Booking BookTableToDelete = _context.BookingTables.Find(id);
            if (BookTableToDelete != null)
            {
                // Placeholder logic to delete an event
                _context.BookingTables.Remove(BookTableToDelete);
                _context.SaveChanges();
            }
        }
                
    }
}

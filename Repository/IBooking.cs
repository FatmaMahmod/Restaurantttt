using Yummy.Models;
using YUMMY.Models;

namespace Yummy.Repository
{
    public interface IBooking
    {
        public List<Booking> GetAllBookingTables();
        public Booking GetBookingTablesDetails(int id);
        public void InsertBookingTables(Booking Booking);
        public void UpdateBookingTables(int id, Booking Booking);
        public void DeleteBookingTables(int id);
    }
}

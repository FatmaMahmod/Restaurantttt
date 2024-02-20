using Yummy.Data;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Serviece
{
    public class EventRepoService : IEvent
    {
       public ApplicationDbContext _context;

        public EventRepoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Event> GetAllEvent()
        {
            // Placeholder logic to get all events
            return _context.Events.ToList();
        }

        public Event GetEventDetails(int id)
        {
            // Placeholder logic to get event details by ID
            return _context.Events.Find(id);
        }

        public void InsertEvent(Event newEvent)
        {
            // Placeholder logic to insert a new event
            _context.Events.Add(newEvent);
            _context.SaveChanges();
        }

        public void UpdateEvent(int id, Event updatedEvent)
        {
            Event existingEvent = _context.Events.Find(id);
            if (existingEvent != null)
            {
                // Placeholder logic to update an existing event
                existingEvent.EventName = updatedEvent.EventName;
                existingEvent.EventDescription = updatedEvent.EventDescription;
                existingEvent.EventPricce = updatedEvent.EventPricce;
                existingEvent.EventImage = updatedEvent.EventImage;
                _context.SaveChanges();
            }
        }

        public void DeleteEvent(int id)
        {
            Event eventToDelete = _context.Events.Find(id);
            if (eventToDelete != null)
            {
                // Placeholder logic to delete an event
                _context.Events.Remove(eventToDelete);
                _context.SaveChanges();
            }
        }
    }
}

using YUMMY.Models;

namespace Yummy.Repository
{
    public interface IEvent
    {
        public List<Event> GetAllEvent();
        public Event GetEventDetails(int id);
        public void InsertEvent(Event chef);
        public void UpdateEvent(int id, Event Event);
        public void DeleteEvent(int id);
    }
}

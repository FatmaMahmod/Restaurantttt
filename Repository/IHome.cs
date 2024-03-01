using YUMMY.Models;

namespace Yummy.Repository
{
    public interface IHome
    {
        public List<Chef> GetAllChef();
        public List<Event> GetAllEvent();

    }
}

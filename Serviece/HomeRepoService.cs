using Yummy.Data;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Serviece
{
    public class HomeRepoService : IHome
    {
        public ApplicationDbContext _context;

        public HomeRepoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Chef> GetAllChef()
        {
            return _context.Chefs.ToList();
        }

        public List<Event> GetAllEvent()
        {
            return _context.Events.ToList();
        }
    }
}

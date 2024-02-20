using YUMMY.Models;

namespace Yummy.Repository
{
    public interface IChef
    {
        public List<Chef> GetAllChef();
        public Chef GetChefDetails(int id);
        public void InsertChef(Chef chef);
        public void UpdateChef(int id, Chef Chef);
        public void DeleteChef(int id);
    }
}

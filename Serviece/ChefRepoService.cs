using Yummy.Data;
using Yummy.Repository;
using YUMMY.Models;

namespace Yummy.Serviece
{
    public class ChefRepoService : IChef
    {
        private readonly ApplicationDbContext _context;

        public ChefRepoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Chef> GetAllChef()
        {
            // Placeholder logic to get all chefs
            return _context.Chefs.ToList();
        }

        public Chef GetChefDetails(int id)
        {
            // Placeholder logic to get chef details by ID
            return _context.Chefs.Find(id);
        }

        public void InsertChef(Chef chef)
        {
            // Placeholder logic to insert a new chef
            _context.Chefs.Add(chef);
            _context.SaveChanges();
        }

        public void UpdateChef(int id, Chef updatedChef)
        {
            Chef existingChef = _context.Chefs.Find(id);
            if (existingChef != null)
            {
                // Placeholder logic to update an existing chef
                existingChef.Name = updatedChef.Name;
                existingChef.Brief = updatedChef.Brief;
                existingChef.JobTitle = updatedChef.JobTitle;
                

                _context.SaveChanges();
            }
        }

        public void DeleteChef(int id)
        {
            Chef chefToDelete = _context.Chefs.Find(id);
            if (chefToDelete != null)
            {
                // Placeholder logic to delete a chef
                _context.Chefs.Remove(chefToDelete);
                _context.SaveChanges();
            }
        }
    }
}

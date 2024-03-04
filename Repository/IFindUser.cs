using Yummy.Models;
using Yummy.ViewModel;

namespace Yummy.Repository
{
    public interface IFindUser
    {
        public ApplicationUser FindUser(string Name);
        public string GetUserId();
    }
}

using Yummy.Data;
using Yummy.Models;

namespace Yummy.Repository
{
    public interface IFindUser
    {
        public ApplicationUser FindUser(string Name);
    }
}

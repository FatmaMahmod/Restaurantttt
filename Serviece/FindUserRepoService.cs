using Yummy.Data;
using Yummy.Models;
using Yummy.Repository;

namespace Yummy.Serviece
{
    public class FindUserRepoService:IFindUser
    {
        public ApplicationDbContext Context;
        public FindUserRepoService(ApplicationDbContext context)
        {
            Context = context;
        }

        public ApplicationUser FindUser(string Email)
        {
            return Context.Users.FirstOrDefault(op => op.UserName == Email);
        }
    }
}

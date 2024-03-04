using Microsoft.AspNetCore.Identity;
using Yummy.Data;
using Yummy.Models;
using Yummy.Repository;
using Yummy.ViewModel;

namespace Yummy.Serviece
{
    public class FindUserRepoService:IFindUser
    {
        public ApplicationDbContext Context;
        private readonly IHttpContextAccessor HttpContextAccessor;
        private readonly UserManager<ApplicationUser> UserManager;
        //IdentityUser
        public FindUserRepoService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            Context = context;
            HttpContextAccessor = httpContextAccessor;
            UserManager = userManager;
        }
        public string GetUserId()
        {
            var principal = HttpContextAccessor.HttpContext.User;
            string userId = UserManager.GetUserId(principal);
            return userId;
        }

        public ApplicationUser FindUser(string Email)
        {
            return Context.Users.FirstOrDefault(op => op.UserName == Email);
        }
    }
}

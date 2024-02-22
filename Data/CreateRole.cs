using Microsoft.AspNetCore.Identity;
using Yummy.Roles;

namespace Yummy.Data
{
    public enum Roles
    {
        Admin,
        User
    }
    public class CreateRole
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider service)
        {
            //Seed Roles
            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));

            // creating admin

            var admin = new ApplicationUser
            {
                UserName = "ayaamaged2000@gmail.com",
                Email = "ayaamaged2000@gmail.com",
                FristName = "ayaa",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            var userInDb = await userManager.FindByEmailAsync(admin.Email);
            if (userInDb == null)
            {
                await userManager.CreateAsync(admin, "Ayaa@123");
                await userManager.AddToRoleAsync(admin, Roles.Admin.ToString());
            }
        }
    }
}

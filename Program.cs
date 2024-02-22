using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Yummy.Data;
using Yummy.Repository;
using Yummy.Serviece;
using YUMMY.Models;

namespace Yummy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            //builder.Services.AddDbContext<YummyDB>(options =>
            //   options.UseSqlServer(connectionString));
            //builder.Services.AddDbContext<YummyDB>(
            //  //op => op.UseSqlServer("Data Source=.;Initial Catalog=RepoDB_CU_44;Integrated Security=True")
            //  //op => op.UseSqlServer(builder.Configuration["ConnectionStrings:myConn"])
            //  op => op.UseSqlServer(builder.Configuration.GetConnectionString("myConn"))
            //   );
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<ICategory,CategoryRepoService>();
            builder.Services.AddScoped<IChef,ChefRepoService>();
            builder.Services.AddScoped<IEvent, EventRepoService>();
            builder.Services.AddScoped<IMeal, MealRepoService>();
            builder.Services.AddScoped<IReview, ReviewRepoService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
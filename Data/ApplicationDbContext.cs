using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Yummy.Models;
using Yummy.ViewModel;
using YUMMY.Models;

namespace Yummy.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<Chef> Chefs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Booking> BookingTables { get; set; }
        public virtual DbSet<cart> carts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    //Id = Guid.NewGuid().ToString(),
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "admin",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new IdentityRole()
                {
                    //Id = Guid.NewGuid().ToString(),
                    Id = "2",
                    Name = "User",
                    NormalizedName = "user",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                );
            base.OnModelCreating(builder);


            // Other configurations...


            // Other configurations...
        }

    
    

    }
}
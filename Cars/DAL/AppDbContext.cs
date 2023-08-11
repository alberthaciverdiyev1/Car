using Cars.Models;
using Cars.Models.Cars;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cars.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
        }
       public DbSet<Marka> Markas { get; set; }
       public DbSet<Model> Models { get; set; }
       public DbSet<Vehicles> Vehicles { get; set; }
       public DbSet<Color> Colors { get; set; }
       public DbSet<VehicleImages> VehicleImages { get; set; }
        

    }
}

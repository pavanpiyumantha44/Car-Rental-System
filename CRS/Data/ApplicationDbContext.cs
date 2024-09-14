using CRS.Models;
using Microsoft.EntityFrameworkCore;

namespace CRS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Car> Cars { get; set; }

    }
}

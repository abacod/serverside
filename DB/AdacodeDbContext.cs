using Microsoft.EntityFrameworkCore;

namespace Abacode.DB
{
    public class AdacodeDbContext : DbContext
    {
        public AdacodeDbContext(DbContextOptions<AdacodeDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}

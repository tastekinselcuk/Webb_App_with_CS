using Microsoft.EntityFrameworkCore;
using WebProgramlama.Models.NewFolder;

namespace WebProgramlama.Data
{
    public class InsuranceContext : DbContext
    {

        public InsuranceContext(DbContextOptions<InsuranceContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }

    }
}

namespace myFirstAPI.Data
{
    using global::myFirstAPI.Models;
    using Microsoft.EntityFrameworkCore;

    namespace myFirstAPI.Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            public DbSet<Product> Products { get; set; }
        }
    }
}

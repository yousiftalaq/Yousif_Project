using Microsoft.EntityFrameworkCore;
using Yousif_Project.Models;

namespace Yousif_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opstions) : base(opstions)
        {

        }

        public DbSet<Category> Category { get; set; }

        public DbSet<ApplicationType> ApplicationType { get; set; }

        public DbSet<Product> Product { get; set; }
    }
}

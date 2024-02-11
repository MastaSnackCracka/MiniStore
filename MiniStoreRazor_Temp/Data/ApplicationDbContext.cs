using Microsoft.EntityFrameworkCore;
using MiniStoreRazor_Temp.Models;

namespace MiniStoreRazor_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Hero", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Villain", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Monster", DisplayOrder = 3 }
            );


        }
    }
}

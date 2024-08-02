using LoginSystemTask.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginSystemTask.Data_Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your model here if needed
        }
    }


}

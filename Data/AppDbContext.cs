using Microsoft.EntityFrameworkCore;
using BookCollection.Models;

namespace BookCollection.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "Server=localhost;Database=BookDb;User=root;Password=67479@Jade10;",
                new MySqlServerVersion(new Version(8, 0, 40))
            );
        }
    }
}

using bigscreens_back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace bigscreens_back_end.Data
{
    public class BigScreenDbContext : DbContext
    {
        public DbSet<Show> Shows { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BigScreenDb");
        }

    }
}

using Day19HTML5CSSPart1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day19HTML5CSSPart1.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\demos;Initial Catalog=testDay19DB;Integrated Security=True;Trust Server Certificate=True");
            // base.OnConfiguring(optionsBuilder);
        }
    }
}

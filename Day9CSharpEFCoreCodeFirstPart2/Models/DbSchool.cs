using Microsoft.EntityFrameworkCore;

namespace Day9CSharpEFCoreCodeFirstPart2.Models
{
    public class DbSchool : DbContext // Database 
    {
        public DbSet<Student> Students { get; set; } //table 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.\EDPI2024R2;Database=SchoolDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}

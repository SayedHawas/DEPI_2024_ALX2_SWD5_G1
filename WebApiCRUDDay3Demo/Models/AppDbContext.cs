using Microsoft.EntityFrameworkCore;

namespace WebApiCRUDDay3Demo.Models
{
    //1- create Class Inhert from DbContext Microsoft.EntityFrameworkCore
    public class AppDbContext : DbContext
    {
        //2- Create CTOR
        public AppDbContext()
        {

        }
        //Options  HardCode 
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        //3- DbSet For All Classes in DbContext
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; } // Call as Table 
        public DbSet<Company> Companies { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);
        //    //HardCode 
        //    //optionsBuilder.UseSqlServer("Data Source=.\\demos;Initial Catalog=WebApiDay3DB;Integrated Security=True;Trust Server Certificate=True");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seek Data 
            // Initial Data 
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, Name = "HR" },
                new Department { DepartmentId = 2, Name = "Developer" }
                );
            base.OnModelCreating(modelBuilder);
        }

    }
}

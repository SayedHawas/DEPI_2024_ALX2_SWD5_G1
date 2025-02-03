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
        public DbSet<Employee> Employees { get; set; } // Call as Table 


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);
        //    //HardCode 
        //    //optionsBuilder.UseSqlServer("Data Source=.\\demos;Initial Catalog=WebApiDay3DB;Integrated Security=True;Trust Server Certificate=True");
        //}


    }
}

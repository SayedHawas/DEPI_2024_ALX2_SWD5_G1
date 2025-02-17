using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApiCRUDDay3Demo.Models
{

    //DataAnnotations
    //1-Scaffolding (Handling Create Database) To build Database (Wizard)
    //2-Validation Data   Server Side   | Client Side Validation 

    //[Table(name: "TblEmployees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = null!;
        [MaxLength(100)]
        public string Job { get; set; }
        [Required]
        [RegularExpression(@"^\d+.?\d{0,2}$")]
        [Range(0, 99999.99)]
        public decimal Salary { get; set; }

        // Navigation Property
        //[ForeignKey(nameof(Department))] 
        [ForeignKey("Department")]
        [Required]
        public int DepartmentId { get; set; }

        // public virtual Department Department { get; set; }
    }
    //public class test : Employee
    //{
    //    public test()
    //    {

    //    }
    //    override 
    //}
}

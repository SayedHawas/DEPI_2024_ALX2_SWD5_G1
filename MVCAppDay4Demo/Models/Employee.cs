using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAppDay4Demo.Models
{
    public class Employee
    {
        //Create Database 
        //Validation (Server Side & Client side "Jquery" )
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Must Enter 100 Letters")]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(100, ErrorMessage = "Must Enter 100 Letters")]
        public string Job { get; set; } = null!;
        [Required]
        [Range(0, 99999)]
        public double Salary { get; set; }

        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }

    }
}

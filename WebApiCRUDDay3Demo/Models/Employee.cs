using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApiCRUDDay3Demo.Models
{

    //DataAnnotations
    //1-Scaffolding To build Database
    //2-Validation Data

    [Table(name: "TblEmployees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Job { get; set; }
        [Required]
        [RegularExpression(@"^\d+.?\d{0,2}$")]
        [Range(0, 99999.99)]
        public decimal Salary { get; set; }
    }
}

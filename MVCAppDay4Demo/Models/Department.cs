using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCAppDay4Demo.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [DisplayName("Department")]
        [Required(ErrorMessage = "Please Enter the Department Name ")]
        [MaxLength(50, ErrorMessage = "Please Enter Name Less than 50  Letters ")]
        public string DepartmentName { get; set; } = null!;

        [MaxLength(150, ErrorMessage = "Please Enter Name Less than 150  Letters ")]
        [DisplayName("Manager")]
        public string? DepartmentManager { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}

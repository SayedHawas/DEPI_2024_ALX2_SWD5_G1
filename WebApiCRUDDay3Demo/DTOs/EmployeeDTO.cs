using System.ComponentModel.DataAnnotations;

namespace WebApiCRUDDay3Demo.DTOs
{
    public class EmployeeDTO
    {
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
        public string DepartmentName { get; set; }
    }
}

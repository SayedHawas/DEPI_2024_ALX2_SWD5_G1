using System.ComponentModel.DataAnnotations;

namespace WebApiDay5Demo.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

    }
}


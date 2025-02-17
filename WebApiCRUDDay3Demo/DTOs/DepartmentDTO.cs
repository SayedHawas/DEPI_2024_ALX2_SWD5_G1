using System.ComponentModel.DataAnnotations;

namespace WebApiCRUDDay3Demo.DTOs
{
    public class DepartmentDTO
    {
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}

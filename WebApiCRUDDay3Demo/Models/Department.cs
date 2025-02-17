using System.ComponentModel.DataAnnotations;

namespace WebApiCRUDDay3Demo.Models
{
    //Model Data 
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        //public int? Counter { set; get; } = null;
        // Navigation Property
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}

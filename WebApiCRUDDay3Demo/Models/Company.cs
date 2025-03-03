using System.ComponentModel.DataAnnotations;

namespace WebApiCRUDDay3Demo.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

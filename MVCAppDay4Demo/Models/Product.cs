using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCAppDay4Demo.Models
{
    public class Product
    {
        [Key]
        [DisplayName("Code")]
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Must Enter 100 Letters")]
        public string Name { get; set; } = null!;
        [MaxLength(300, ErrorMessage = "Must Enter 300 Letters")]
        public string Description { get; set; }
        [Required]
        [Range(0, 99999, ErrorMessage = "Must enter Number between 0 To 99999")]
        public double Price { get; set; }
        //Static File 
        public string Image { get; set; }
    }
}

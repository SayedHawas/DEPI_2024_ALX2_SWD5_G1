.using System.ComponentModel.DataAnnotations;

namespace Day28DatabaseFirst.Models
{

    [MetadataType(typeof(Category))]
    public class CategoryKeep
    {
        [Required]
        public string CategoryName { get; set; } = null!;
    }
}

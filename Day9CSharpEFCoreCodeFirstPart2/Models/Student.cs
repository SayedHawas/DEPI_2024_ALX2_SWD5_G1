using System.ComponentModel.DataAnnotations;

namespace Day9CSharpEFCoreCodeFirstPart2.Models
{
    public class Student
    {
        //Data Annotation Attribute 
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int Age { get; set; }
    }
}

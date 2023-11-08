using System.ComponentModel.DataAnnotations;

namespace blueFirstApp.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(18,35,ErrorMessage ="User must be 18-35" )]
        public int Age { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}

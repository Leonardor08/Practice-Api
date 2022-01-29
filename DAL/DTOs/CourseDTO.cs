using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class CourseDTO
    {
        [Key]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        [Display(Name = "Nombre")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "The Description is required")]
        [Display(Name = "Descripción")]
        public string CourseDescription { get; set; }
    }
}

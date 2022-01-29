using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class StudentDTO
    {
        [Key]        
        public int studentId { get; set; }

        [Required(ErrorMessage = "The is required")]
        [Display(Name = "")]
        public string studentName { get; set; }

        [Required(ErrorMessage = "The is required")]
        [Display(Name = "")]
        public int studentNumber { get; set; }

        [Required(ErrorMessage = "The is required")]
        [Display(Name = "")]
        public string studentAddres { get; set; }
    }
}

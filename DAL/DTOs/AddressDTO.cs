using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class AddressDTO
    {
        [Key]
        public int iD { get; set; }

        [Required(ErrorMessage = "The Description is required")]
        [Display(Name = "Desctipción")]
        public string DescriptionAddress { get; set; }
    }
}

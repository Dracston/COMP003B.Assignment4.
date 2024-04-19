using System.ComponentModel.DataAnnotations;
namespace COMP003B.Assignment4_.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^[_A-Za-z'`+-.]+([_A-Za-z0-9'+-.]+)*@([A-Za-z0-9-])+(\\.[A-Za-z0-9]+)*(\\.([A-Za-z]*){3,})$", ErrorMessage = "Enter proper email")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Not a Valid Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage ="Not a Valid Phone Number")]
        public string Phone {  get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [Range(0,50)]
        [Display(Name="Size of your Party")]
        public int Party {  get; set; }

    }
}

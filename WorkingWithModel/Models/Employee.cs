using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WorkingWithModel.Models
{
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [DisplayName("Employee Name")]
        [MinLength(2)]
        [MaxLength(20)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Id")]
        [Required(ErrorMessage = "Emailid is required")]
        public string EmailId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
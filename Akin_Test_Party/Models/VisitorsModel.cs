using System.ComponentModel.DataAnnotations;

namespace Akin_Test_Party.Models
{
    public class VisitorsModel
    {
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "field must be at least 3 characters and max 20 characters")]
        [Display(Name = "Your First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "field must be at least 3 characters and max 25 characters")]
        [Display(Name = "Your Last Name")]
        public string SecondName { get; set; }

        [EmailAddress(ErrorMessage ="Please enter a proper mail address")]
        [Display(Name = "Your E-mail Address")]
        public string EmailAdress { get; set; }

        [Required]
        [Display(Name = "Your Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(18, 60, ErrorMessage = "You can enter your age between 18 - 60")]
        [Display(Name = "Your Age")]
        public int Age { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Your Home Address")]
        public string Address { get; set; }

        [Required]
        [Range(1000, 15000, ErrorMessage = "You can enter Postal Code between 1000 - 15000")]
        [Display(Name = "Your Postal Code")]
        public int PostalCode { get; set; }

        [Required]
        [Display(Name = "The City Do You Live in")]
        public string City { get; set; }

        [Display(Name = "Are You a Family?")]
        public bool IsFamily { get; set; }
    }
}

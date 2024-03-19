using System;
using System.ComponentModel.DataAnnotations;

namespace SMS.Model
{
    public class StudentDetails
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; } 

        [Required]
        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "*"), RegularExpression(@"^[0-9]{10}$", ErrorMessage = "*")]
        public long PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }
       
        [DataType(DataType.Date)]
        [Display(Name = "DOB")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Standard")]
        public string Standard { get; set; }

        [Required]
        public string City { get; set; }
    }
    
}

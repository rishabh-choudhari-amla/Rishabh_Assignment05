using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Model
{
    public class SignupDetails
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


        [Required]
        public string Designation { get; set; }

        [Required]
        public string Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "*"), RegularExpression(@"^[0-9]{10}$", ErrorMessage = "*")]

        public string PhoneNumber { get; set; }


        [Required]
        public string Email { get; set; }


        [Required]
        public string Address { get; set; }


        [Required]
        public string City { get; set; }
    }
}

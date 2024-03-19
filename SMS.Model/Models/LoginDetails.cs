using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMS.Model
{
    public class LoginDetails
    {
        
        [Display(Name ="Email")]
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

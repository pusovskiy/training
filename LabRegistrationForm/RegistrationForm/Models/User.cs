using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class User
    {   
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }


        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must contain minimum 6 symbols")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-zA-Z]).{6,}$", ErrorMessage = "Password must contain at least one digit")]
        public string Password { get; set; }

        [Required]
        [Compare("Password",ErrorMessage ="Different with password")]
        public string ReEnterPassword { get; set; }

        [Required]
        [Range(19,99,ErrorMessage ="Age must be in 18-99 range")]
        public string Age { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [StringLength(100,MinimumLength = 5,ErrorMessage ="Field must contain at least 20 symbols")]
        public string Address { get; set; }

        

    }
}
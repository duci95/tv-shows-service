using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tv_shows_service.app.DTO
{
    public class UserInsertDTO
    {
        [Required(ErrorMessage = "First name is required"),
        MinLength(2, ErrorMessage = "Minimum length for first name is 2"),
        MaxLength(30, ErrorMessage = "Maximum length for first name is 30")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required"),
        MinLength(2, ErrorMessage = "Minimum length for last name is 2"),
        MaxLength(50, ErrorMessage = "Maximum length for last name is 50")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required"),
        EmailAddress(ErrorMessage ="Invalid email value"),
        MaxLength(70, ErrorMessage = "Maximum length for email is 70")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required"),
        MinLength(6,ErrorMessage = "Minimum length for username is 6"),
        MaxLength(30, ErrorMessage = "Maximum length for username name is 30")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required"),
        MinLength(8, ErrorMessage = "Minimum length for password is 8"),
        MaxLength(25, ErrorMessage = "Maximum length for password is 25")]
        public string Password { get; set; }

        [Required, Compare("Password")]
        public string PasswordRepeat { get; set; }
    }
}

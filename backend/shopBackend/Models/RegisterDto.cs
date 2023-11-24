using shopBackend.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace shopBackend.Models
{
    public class RegisterDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public UserRole Role { get; set; }
    }
}

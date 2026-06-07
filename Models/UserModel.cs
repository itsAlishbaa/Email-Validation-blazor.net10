using System.ComponentModel.DataAnnotations;

namespace q2.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(20, ErrorMessage = "First name is too long.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(20, ErrorMessage = "Last name is too long.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = string.Empty;
    }
}
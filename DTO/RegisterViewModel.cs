using System.ComponentModel.DataAnnotations;

namespace TechnicalTassk.DTO
{
    public class RegisterViewmodel
    {

        [Required]
        [StringLength(60)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string Password { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string ConfirmPassword { get; set; }
    }
}

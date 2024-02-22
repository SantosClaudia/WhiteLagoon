using System.ComponentModel.DataAnnotations;

namespace WhiteLagoon.Web.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        [Display(Name = "PhoneNumber")]
        public string? PhoneNumber { get; set; } = null!;

        public string? RedirectUrl { get; set; }
    }
}

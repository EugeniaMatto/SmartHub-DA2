using System.ComponentModel.DataAnnotations;

namespace SmartHub.Model.Request;
public class CompanyOwnerRequest
{
    [Required(ErrorMessage = "Name is required")]
    [MinLength(1, ErrorMessage = "Name cannot be empty")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Surname is required")]
    [MinLength(1, ErrorMessage = "Surname cannot be empty")]
    public required string Surname { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "The email must be in a valid format (e.g., user@domain.com).")]
    public required string Email { get; set; }

    [Required]
    [MinLength(6, ErrorMessage = "The password must be at least 6 characters long.")]
    [RegularExpression(@"^(?=.*[!@#$%^&*(),.?""{}|<>]).*$", ErrorMessage = "The password must contain at least one special character.")]
    public required string Password { get; set; }
}

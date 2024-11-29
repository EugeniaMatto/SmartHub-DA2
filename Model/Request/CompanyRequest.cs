using System.ComponentModel.DataAnnotations;

namespace SmartHub.Model.Request;
public class CompanyRequest
{
    [Required(ErrorMessage = "Name is required")]
    [MinLength(1, ErrorMessage = "Name cannot be empty")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Logo is required")]
    [MinLength(1, ErrorMessage = "Logo cannot be empty")]
    public required string LogoUrl { get; set; }

    [Required(ErrorMessage = "RUT is required")]
    [MinLength(1, ErrorMessage = "RUT cannot be empty")]
    [RegularExpression(@"^\d+$", ErrorMessage = "RUT can only contain numbers")]
    public required string Rut { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHub.Domain;
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;

    [Required]
    [EmailAddress(ErrorMessage = "The email must be in a valid format (e.g., user@domain.com).")]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MinLength(6, ErrorMessage = "The password must be at least 6 characters long.")]
    [RegularExpression(@"^(?=.*[!@#$%^&*(),.?""{}|<>]).*$", ErrorMessage = "The password must contain at least one special character.")]
    public string Password { get; set; } = string.Empty;
    public string ProfilePhoto { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public List<Permission> Permissions { get; init; } = [];
    public List<UserHomePermission> HomePermissions { get; set; } = [];
    public List<Home> OwnedHomes { get; set; } = [];
    public List<Role> Roles { get; set; } = [];

    public bool HasPermission(Permission permission)
    {
        return Permissions.Any(p => p.Name == permission.Name);
    }

    public void AddPermission(Permission permission)
    {
        Permissions.Add(permission);
    }

    public void RemovePermission(Permission permission)
    {
        Permissions.Remove(permission);
    }
}

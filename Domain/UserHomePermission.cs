using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHub.Domain;
public class UserHomePermission
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; } = new();
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public List<HomePermission> Permissions { get; set; } = [];
    public Home Home { get; set; } = null!;
    public Guid HomeId { get; set; }
}

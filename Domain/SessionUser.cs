using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHub.Domain;
public sealed record class SessionUser
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Token { get; set; }
    public Guid UserId { get; set; }
    public required User User { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

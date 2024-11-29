using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHub.Domain;
public class Notification
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public Guid HardwareId { get; set; }
    public Hardware Hardware { get; set; } = null!;
    public string Event { get; set; } = string.Empty;
    public bool Seen { get; set; } = false;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public string UserEmail { get; set; } = null!;
}

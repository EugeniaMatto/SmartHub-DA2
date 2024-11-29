using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHub.Domain;
public class NotificationMember
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public Guid HomeId { get; set; }
    public Home? Home { get; set; }

    public Guid UserId { get; set; }
    public User? User { get; set; }
}

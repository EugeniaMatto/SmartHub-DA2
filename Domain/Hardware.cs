using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHub.Domain;
public class Hardware
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public bool Online { get; set; } = true;
    public Home Home { get; set; } = null!;
    public Guid HomeId { get; set; }
    public Device Device { get; set; } = null!;
    public Guid DeviceId { get; set; }
    public string? Room { get; set; } = null;
}

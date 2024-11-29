using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHub.Domain;

public class Device
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public DeviceType Type { get; set; }
    public List<string> Photos { get; set; } = [];
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public Guid CompanyId { get; set; }
    public Company Company { get; set; } = null!;
    public override string ToString()
    {
        return $"Device Name: {Name}";
    }

    public Device()
    {
        CreatedAt = DateTime.Now;
        Id = Guid.NewGuid();
    }
}

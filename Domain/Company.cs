using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHub.Domain;

public class Company
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string LogoURL { get; set; } = string.Empty;
    public string Rut { get; set; } = string.Empty;
    public User Owner { get; set; } = null!;
    public Guid OwnerId { get; set; }
    public List<Device> Devices { get; set; } = [];
    public string Validator { get; set; } = string.Empty;

    public Company()
    {
    }

    public Company(string name, string logoURL, User user, string rut)
    {
        Id = Guid.NewGuid();
        Name = name;
        LogoURL = logoURL;
        Owner = user;
        OwnerId = user.Id;
        Rut = rut;
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHub.Domain;

public sealed record class Permission
{

    public string Name { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    public Permission()
    {
        Name = string.Empty;
    }

    public Permission(string value)
    {
        Name = value;
    }

    public override string ToString()
    {
        return Name;
    }
}

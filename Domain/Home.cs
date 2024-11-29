using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SmartHub.Exceptions;

namespace SmartHub.Domain;
public class Home
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Street { get; set; } = string.Empty;

    public string StreetNumber { get; set; } = string.Empty;

    public UbicationGeo Ubication { get; set; } = new UbicationGeo(0, 0);

    public List<UserHomePermission> Members { get; set; } = [];

    public List<NotificationMember> NotificationMembers { get; set; } = [];

    public Guid OwnerId { get; set; }

    public User Owner { get; set; } = null!;

    public List<Hardware> Devices { get; set; } = [];
    public List<string> Rooms { get; set; } = [];

    public int MaxMembers { get; set; } = 1;

    public Home(string name, string street, string streetNumber, UbicationGeo ubication, User owner, int maxMembers)
    {
        Name = name;
        Street = street;
        StreetNumber = streetNumber;
        Ubication = ubication;
        Owner = owner;
        MaxMembers = maxMembers;
        OwnerId = Owner.Id;
        NotificationMembers = [];
        Members = [];
    }

    public Home()
    {
    }

    public void AddMember(UserHomePermission member)
    {
        if (Members.Count >= MaxMembers)
        {
            throw new InvalidValueException("MaxMembers", null, new { Reason = "Cannot add more members; the limit has been reached." });
        }

        Members.Add(member);
    }

    public void RemoveMember(UserHomePermission member)
    {
        if (!Members.Remove(member))
        {
            throw new NotFoundException("Member", member.User.Id);
        }
    }
}

using SmartHub.Domain;

namespace SmartHub.Model.Response;
public readonly struct HomeResponse
{
    public Guid Id { get; }
    public string Name { get; }
    public string Street { get; }
    public string StreetNumber { get; }
    public UbicationGeo Ubication { get; }
    public string Owner { get; }
    public List<string> Rooms { get; }
    public int MaxMembers { get; }

    public HomeResponse(Guid id, string name, string street, string streetNumber, UbicationGeo ubication, string owner, List<string> rooms, int maxMembers)
    {
        Id = id;
        Name = name;
        Street = street;
        StreetNumber = streetNumber;
        Ubication = ubication;
        Owner = owner;
        Rooms = rooms ?? [];
        MaxMembers = maxMembers;
    }
}

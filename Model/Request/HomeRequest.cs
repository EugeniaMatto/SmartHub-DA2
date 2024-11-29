using System.ComponentModel.DataAnnotations;

namespace SmartHub.Model.Request;
public class HomeRequest
{
    public string Name { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string StreetNumber { get; set; } = null!;
    public UbicationGeoRequest Ubication { get; set; } = null!;
    [Range(1, 5)]
    public int MaxMembers { get; set; }
    public List<string> Rooms { get; set; } = [];
}

namespace SmartHub.Domain;

public class UbicationGeo
{
    public int? Lat { get; set; }
    public int? Lon { get; set; }

    public UbicationGeo(int lat, int lon)
    {
        Lat = lat;
        Lon = lon;
    }

    public UbicationGeo()
    {
        Lat = 0;
        Lon = 0;
    }
}

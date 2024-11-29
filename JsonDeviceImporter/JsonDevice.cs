using System.Text.Json.Serialization;

namespace JsonDeviceImporter;
public class JsonDevice
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("tipo")]
    public required string Tipo { get; set; }
    [JsonPropertyName("nombre")]
    public required string Nombre { get; set; }
    [JsonPropertyName("modelo")]
    public required string Modelo { get; set; }
    [JsonPropertyName("fotos")]
    public required List<JsonPhoto> Fotos { get; set; }
    [JsonPropertyName("person_detection")]
    public bool? Person_Detection { get; set; } = false;
    [JsonPropertyName("movement_detection")]
    public bool? Movement_Detection { get; set; } = false;
}

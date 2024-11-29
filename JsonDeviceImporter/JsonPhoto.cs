using System.Text.Json.Serialization;
namespace JsonDeviceImporter;

public class JsonPhoto
{
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    [JsonPropertyName("es_principal")]
    public bool Es_principal { get; set; }
}

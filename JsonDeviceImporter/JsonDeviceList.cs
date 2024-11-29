using System.Text.Json.Serialization;

namespace JsonDeviceImporter;
public class JsonDeviceList
{
    [JsonPropertyName("dispositivos")]
    public required List<JsonDevice> Dispositivos { get; set; }
}

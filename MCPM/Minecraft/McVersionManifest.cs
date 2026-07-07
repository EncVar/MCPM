using System.Text.Json.Serialization;

namespace MCPM.Minecraft;

public class McVersionManifest
{
    [JsonPropertyName("versions")]
    public List<McVersion> Versions { get; set; }
}
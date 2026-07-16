using System.Text.Json.Serialization;

namespace MCPM.Minecraft;

public class McVersionManifest
{

    public required McLatestVersion Latest { get; set; }

    [JsonPropertyName("versions")]
    public required List<McVersion> Versions { get; set; }
}
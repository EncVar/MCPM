using System.Text.Json.Serialization;

namespace MCPM.Package.Minecraft;

public class McVersionManifest
{
    public const string ManifestUrl = "https://piston-meta.mojang.com/mc/game/version_manifest_v2.json";
    
    [JsonPropertyName("latest")]
    public required McLatestVersion Latest { get; set; }

    [JsonPropertyName("versions")]
    public required List<McVersion> Versions { get; set; }
}
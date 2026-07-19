using System.Text.Json.Serialization;

namespace MCPM.Instance;

public class Config
{
    [JsonPropertyName("instanceIsolation")]
    public required bool InstanceIsolation { get; set; }
    
    [JsonPropertyName("windowTitle")]
    public string? WindowTitle { get; set; }

    [JsonPropertyName("customText")]
    public string? CustomText { get; set; } = "MCPM";
    
    [JsonPropertyName("maxMemory")]
    public required int MaxMemory { get; set; }
}
using System.Text.Json.Serialization;

namespace MCPM.Minecraft;

public class McVersion
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("url")]
    public string JsonUrl { get; set; }
    [JsonPropertyName("time")]
    public DateTime Time { get; set; }
    [JsonPropertyName("releaseTime")]
    public DateTime ReleaseTime { get; set; }
    
    public static bool operator < (McVersion a, McVersion b)
    {
        return a.ReleaseTime < b.ReleaseTime;
    }
    
    public static bool operator > (McVersion a, McVersion b)
    {
        return a.ReleaseTime > b.ReleaseTime;
    }

    public static bool operator == (McVersion a, McVersion b)
    {
        return a.ReleaseTime == b.ReleaseTime;
    }
    
    public static bool operator != (McVersion a, McVersion b)
    {
        return a.ReleaseTime != b.ReleaseTime;
    }
}

public class McLatestVersion
{
    
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum McVersionType
{
    [JsonPropertyName("snapshot")]
    Snapshot,
    [JsonPropertyName("release")]
    Release,
    [JsonPropertyName("old_alpha")]
    OldAlpha,
    [JsonPropertyName("old_beta")]
    OldBeta
}
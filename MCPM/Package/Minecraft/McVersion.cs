using System.Text.Json.Serialization;

namespace MCPM.Package.Minecraft;

public class McVersion
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("url")]
    public required string JsonUrl { get; set; }

    [JsonPropertyName("time")]
    public required DateTime Time { get; set; }

    [JsonPropertyName("releaseTime")]
    public required DateTime ReleaseTime { get; set; }

    [JsonPropertyName("sha1")]
    public required string Sha1 { get; set; }

    [JsonPropertyName("complianceLevel")]
    public required int ComplianceLevel { get; set; }
    
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

    public override bool Equals(object? obj)
    {
        if (obj is McVersion v)
            return v == this;
        return false;
    }

    public override int GetHashCode()
    {
        return 
            Id.GetHashCode() ^
            Time.GetHashCode() ^
            ReleaseTime.GetHashCode();
    }
}

public class McLatestVersion
{
    [JsonPropertyName("release")]
    public required string Release { get; set; }

    [JsonPropertyName("version")]
    public required string Snapshot { get; set; }
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
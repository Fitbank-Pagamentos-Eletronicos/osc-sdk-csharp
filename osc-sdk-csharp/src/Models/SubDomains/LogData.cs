using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.SubDomains;
public record LogData
{
    [Required]
    [JsonProperty(PropertyName = "latitude")]
    public double Latitude { get; set; }

    [Required]
    [JsonProperty(PropertyName = "longitude")]
    public double Longitude { get; set; }

    [Required]
    [JsonProperty(PropertyName = "occurrenceDate")]
    public string? OccurrenceDate { get; set; }

    [Required]
    [JsonProperty(PropertyName = "userAgent")]
    public string? UserAgent { get; set; }

    [Required]
    [JsonProperty(PropertyName = "ip")]
    public string? IP { get; set; }

    [JsonProperty(PropertyName = "mac")]
    public string? MAC { get; set; }

    public LogData(double latitude, double longitude, string? occurrenceDate, string? userAgent, string? iP, string? mAC)
    {
        Latitude = latitude;
        Longitude = longitude;
        OccurrenceDate = occurrenceDate;
        UserAgent = userAgent;
        IP = iP;
        MAC = mAC;
    }
}
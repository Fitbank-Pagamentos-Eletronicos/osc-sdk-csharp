using Newtonsoft.Json;

namespace osc_sdk_csharp.src.Models.SubDomains;

public record Vehicle
{
    [JsonProperty(PropertyName = "licensePlate")]
    public string LicensePlate { get; set; }

    public Vehicle(string licensePlate)
    {
        LicensePlate = licensePlate;
    }
}
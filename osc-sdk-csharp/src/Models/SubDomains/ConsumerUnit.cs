using Newtonsoft.Json;

namespace osc_sdk_csharp.src.Models.SubDomains;

public record ConsumerUnit
{
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    public ConsumerUnit(string number)
    {
        Number = number;
    }
}
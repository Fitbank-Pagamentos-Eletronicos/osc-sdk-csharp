using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;

namespace osc_sdk_csharp.src.Models.SubDomains;

public record ProductCard
{
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    [JsonProperty(PropertyName = "network")]
    public string Network { get; set; }

    [JsonProperty(PropertyName = "payday")]
    public int PayDay { get; set; }

    public ProductCard(int type, int network, int payDay)
    {
        Type = ProductType.GetName(type);
        Network = Enums.Network.GetName(network);
        PayDay = payDay;
    }
}
using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;

namespace osc_sdk_csharp.src.Models.SubDomains;
public record ProductLoan
{
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    [JsonProperty(PropertyName = "installments")]
    public int Installments { get; set; }

    public ProductLoan(int type, string value, int installments)
    {
        Type = ProductType.GetName(type);
        Value = value;
        Installments = installments;
    }
}
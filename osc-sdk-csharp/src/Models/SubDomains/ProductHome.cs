using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;

namespace osc_sdk_csharp.src.Models.SubDomains;
public record ProductHome
{
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    [JsonProperty(PropertyName = "installments")]
    public int Installments { get; set; }

    [JsonProperty(PropertyName = "realestatetype")]
    public string RealEstateType { get; set; }

    [JsonProperty(PropertyName = "realestatevalue")]
    public string RealEstateValue { get; set; }

    [JsonProperty(PropertyName = "outstandingbalance")]
    public string OutstandingBalance { get; set; }

    public ProductHome(int type, string value, int installments, int realEstateType, string realEstateValue, string outstandingBalance)
    {
        Type = ProductType.GetName(type);
        Value = value;
        Installments = installments;
        RealEstateType = Enums.RealEstateType.GetName(realEstateType);
        RealEstateValue = realEstateValue;
        OutstandingBalance = outstandingBalance;
    }
}
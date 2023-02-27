using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;

namespace osc_sdk_csharp.src.Models.SubDomains;

public record ProductAuto
{
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    [JsonProperty(PropertyName = "vahiclebrand")]
    public string VehicleBrand { get; set; }

    [JsonProperty(PropertyName = "vehiclemodel")]
    public string VehicleModel { get; set; }

    [JsonProperty(PropertyName = "installments")]
    public int Installments { get; set; }

    [JsonProperty(PropertyName = "vehiclemodelyear")]
    public string VehicleModelYear { get; set; }

    [JsonProperty(PropertyName = "codefipe")]
    public string CodeFIPE { get; set; }

    [JsonProperty(PropertyName = "vehiclefipevalue")]
    public string FIPEValue { get; set; }

    public ProductAuto(int type, string value, string vehicleBrand, string vehicleModel, int installments, string vehicleModelYear, string codeFIPE, string fIPEValue)
    {
        Type = ProductType.GetName(type);
        Value = value;
        VehicleBrand = vehicleBrand;
        VehicleModel = vehicleModel;
        Installments = installments;
        VehicleModelYear = vehicleModelYear;
        CodeFIPE = codeFIPE;
        FIPEValue = fIPEValue;
    }
}
using Newtonsoft.Json;

namespace osc_sdk_csharp.src.Models.SubDomains;

public record BusinessIncome
{
    [JsonProperty(PropertyName = "income")]
    public int Income { get; set; }

    public BusinessIncome(int income)
    {
        Income = income;
    }
}

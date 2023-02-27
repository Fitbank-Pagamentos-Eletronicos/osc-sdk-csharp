using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;
using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.SubDomains;

public class Bank
{
    [Required]
    [JsonProperty(PropertyName = "bank")]
    public string Banks { get; set; }

    [Required]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    [Required]
    [JsonProperty(PropertyName = "agency")]
    public string Agency { get; set; }

    [Required]
    [JsonProperty(PropertyName = "account")]
    public string Account { get; set; }

    public Bank(string banks, int type, string agency, string account)
    {
        Banks = banks;
        Type = AccountType.GetName(type);
        Agency = agency;
        Account = account;
    }
}
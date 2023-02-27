using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;
using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.SubDomains;

public record Identity
{
    [Required]
    [JsonProperty(PropertyName = "type")]
    public string IdentityType { get; set; }

    [Required]
    [JsonProperty(PropertyName = "number")]
    public string IdentityNumber { get; set; }

    [Required]
    [JsonProperty(PropertyName = "issuer")]
    public string Issuer { get; set; }

    [Required]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    [Required]
    [JsonProperty(PropertyName = "issuingDate")]
    public string IssuingDate { get; set; }

    public Identity(int identityType, string identityNumber, int issuer, int state, string issuingDate)
    {
        IdentityType = Enums.IdentityType.GetName(identityType);
        IdentityNumber = identityNumber;
        Issuer = IdentityIssuer.GetName(issuer);
        State = Enums.State.GetName(state);
        IssuingDate = issuingDate;
    }
}
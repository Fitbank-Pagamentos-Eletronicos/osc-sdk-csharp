using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.SubDomains;

public record Address
{
    [Required]
    [MinLength(4)]
    [MaxLength(8)]
    [RegularExpression("^[0-9]*$")]
    [JsonProperty(PropertyName = "zipCode")]
    public string ZipCode { get; set; }

    [Required]
    [JsonProperty(PropertyName = "address")]
    public string Street { get; set; }

    [Required]
    [RegularExpression("^[0-9]*$")]
    [JsonProperty(PropertyName = "number")]
    public int Number { get; set; }

    [JsonProperty(PropertyName = "complement")]
    public string Complement { get; set; }

    [Required]
    [JsonProperty(PropertyName = "district")]
    public string District { get; set; }

    [Required]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    [Required]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    [Required]
    [JsonProperty(PropertyName = "homeType")]
    public string HomeType { get; set; }

    [Required]
    [JsonProperty(PropertyName = "homeSince")]
    public string HomeSince { get; set; }

    public Address(string zipCode, string street, int number, string complement, string district, int state, string city, int homeType, int homeSince)
    {
        ZipCode = zipCode;
        Street = street;
        Number = number;
        Complement = complement;
        District = district;
        State = Enums.State.GetName(state);
        City = city;
        HomeType = Enums.HomeType.GetName(homeType);
        HomeSince = Enums.HomeSince.GetName(homeSince);
    }
}
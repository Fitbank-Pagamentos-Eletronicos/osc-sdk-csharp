using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.SubDomains;

public record Business
{
    [Required]
    [JsonProperty(PropertyName = "occupation")]
    public string Occupation { get; set; }

    [Required]
    [JsonProperty(PropertyName = "profession")]
    public string Profession { get; set; }

    [JsonProperty(PropertyName = "companyName")]
    public string CompanyName { get; set; }

    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    [JsonProperty(PropertyName = "income")]
    public int Income { get; set; }

    [Required]
    [JsonProperty(PropertyName = "payday")]
    public int PayDay { get; set; }

    [JsonProperty(PropertyName = "benefitNumber")]
    public string BenefitNumber { get; set; }

    [Required]
    [JsonProperty(PropertyName = "zipCode")]
    public string ZipCode { get; set; }

    [Required]
    [JsonProperty(PropertyName = "address")]
    public string Street { get; set; }

    [Required]
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

    public Business(
        int occupation,
        string profession,
        string companyName,
        string phone,
        int income,
        int payDay,
        string benefitNumber,
        string zipCode,
        string street,
        int number,
        string complement,
        string district,
        int state,
        string city)
    {
        Occupation = Enums.Occupation.GetName(occupation);
        Profession = profession;
        CompanyName = companyName;
        Phone = phone;
        Income = income;
        PayDay = payDay;
        BenefitNumber = benefitNumber;
        ZipCode = zipCode;
        Street = street;
        Number = number;
        Complement = complement;
        District = district;
        State = Enums.State.GetName(state);
        City = city;
    }
}
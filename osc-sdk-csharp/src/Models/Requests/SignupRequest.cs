using Newtonsoft.Json;
using osc_sdk_csharp.src.Models.SubDomains;

namespace osc_sdk_csharp.src.Models.Requests;

//SignupMatch
public record SignupRequest : SimpleSignupRequest
{
    [JsonProperty(PropertyName = "education")]
    public string Education { get; set; }

    [JsonProperty(PropertyName = "banks")]
    public string Banks { get; set; }

    [JsonProperty(PropertyName = "occupation")]
    public string Occupation { get; set; }

    [JsonProperty(PropertyName = "income")]
    public decimal Income { get; set; }

    [JsonProperty(PropertyName = "hascreditcard")]
    public bool HasCreditCard { get; set; }

    [JsonProperty(PropertyName = "hasrestriction")]
    public bool HasRestriction { get; set; }

    [JsonProperty(PropertyName = "hasownhouse")]
    public bool HasOwnHouse { get; set; }

    [JsonProperty(PropertyName = "hasvehicle")]
    public bool HasVehicle { get; set; }

    [JsonProperty(PropertyName = "hasandroid")]
    public bool HasAndroid { get; set; }

    [JsonProperty(PropertyName = "products")]
    public List<Products> Products { get; set; }

    public SignupRequest(
        string cPF,
        string name,
        string birthday,
        string email,
        string phone,
        string zipCode,
        string education, 
        string banks, 
        string occupation, 
        decimal income, 
        bool hasCreditCard, 
        bool hasRestriction, 
        bool hasOwnHouse, 
        bool hasVehicle, 
        bool hasAndroid, 
        List<Products> products,
        LogData logData)
        : base (
            cPF,
            name,
            birthday,
            email,
            phone,
            zipCode,
            logData)
    {
        CPF = cPF;
        Name = name;
        Birthday = birthday;
        Email = email;
        Phone = phone;
        ZipCode = zipCode;
        Education = education;
        Banks = banks;
        Occupation = occupation;
        Income = income;
        HasCreditCard = hasCreditCard;
        HasRestriction = hasRestriction;
        HasOwnHouse = hasOwnHouse;
        HasVehicle = hasVehicle;
        HasAndroid = hasAndroid;
        Products = products;
        LogData = logData;
    }
}
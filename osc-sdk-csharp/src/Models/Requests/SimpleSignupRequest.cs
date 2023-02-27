using Newtonsoft.Json;
using osc_sdk_csharp.src.Models.SubDomains;
using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.Requests;

//SimpleSignup
public record SimpleSignupRequest
{
    [Required]
    [MinLength(3)]
    [MaxLength(11)]
    [RegularExpression("^[0-9]*$")]
    [JsonProperty(PropertyName = "cpf")]
    public string CPF { get; set; }

    [Required]
    [MaxLength(100)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [Required]
    [MinLength(10)]
    [MaxLength(10)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{yyyy/MM/dd}")]
    [JsonProperty(PropertyName = "birthday")]
    public string Birthday { get; set; }

    [Required]
    [MaxLength(100)]
    [EmailAddress]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    [Required]
    [MinLength(11)]
    [MaxLength(11)]
    [RegularExpression("^[0-9]*$")]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    [Required]
    [MinLength(4)]
    [MaxLength(8)]
    [RegularExpression("^[0-9]*$")]
    [JsonProperty(PropertyName = "zipCode")]
    public string ZipCode { get; set; }

    [JsonProperty(PropertyName = "logData")]
    public LogData LogData { get; set; }

    public SimpleSignupRequest(
        string cPF,
        string name,
        string birthday,
        string email,
        string phone,
        string zipCode,
        LogData logData
        )
    {
        CPF = cPF;
        Name = name;
        Birthday = birthday;
        Email = email;
        Phone = phone;
        ZipCode = zipCode;
        LogData = logData;
    }
}
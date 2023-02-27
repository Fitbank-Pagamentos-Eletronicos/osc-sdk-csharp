using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;
using osc_sdk_csharp.src.Models.SubDomains;
using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.Requests;

//Proposal
public class ProposalRequest
{
    [Required]
    [JsonProperty(PropertyName = "mother")]
    public string Mother { get; set; }

    [Required]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    [Required]
    [JsonProperty(PropertyName = "nationality")]
    public string Nationality { get; set; }

    [Required]
    [JsonProperty(PropertyName = "hometownState")]
    public string HometownState { get; set; }

    [Required]
    [JsonProperty(PropertyName = "hometown")]
    public string Hometown { get; set; }

    [Required]
    [JsonProperty(PropertyName = "education")]
    public string Education { get; set; }

    [Required]
    [JsonProperty(PropertyName = "relationshipStatus")]
    public string RelationshipStatus { get; set; }

    [JsonProperty(PropertyName = "phoneLandline")]
    public string PhoneLandLine { get; set; }

    [Required]
    [JsonProperty(PropertyName = "identity")]
    public Identity Identity { get; set; }

    [Required]
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }

    [JsonProperty(PropertyName = "vehicle")]
    public Vehicle Vehicle { get; set; }

    [JsonProperty(PropertyName = "consumerunit")]
    public ConsumerUnit ConsumerUnit { get; set; }

    [Required]
    [JsonProperty(PropertyName = "business")]
    public Business Business { get; set; }

    [Required]
    [JsonProperty(PropertyName = "bank")]
    public Bank Bank { get; set; }

    [JsonProperty(PropertyName = "reference")]
    public List<Reference> Reference { get; set; }

    [JsonProperty(PropertyName = "products")]
    public List<Products> Products { get; set; }

    public ProposalRequest(
        string mother,
        int gender,
        int nationality,
        int hometownState,
        string hometown,
        int education,
        int relationshipStatus,
        string phoneLandLine,
        Identity identity,
        Address address,
        Vehicle vehicle,
        ConsumerUnit consumerUnit,
        Business business,
        Bank bank,
        List<Reference> reference,
        List<Products> products)
    {
        Mother = mother;
        Gender = Enums.Gender.GetName(gender);
        Nationality = Enums.Nationality.GetName(nationality);
        HometownState = State.GetName(hometownState);
        Hometown = hometown;
        Education = Enums.Education.GetName(education);
        RelationshipStatus = Enums.RelationshipStatus.GetName(relationshipStatus);
        PhoneLandLine = phoneLandLine;
        Identity = identity;
        Address = address;
        Vehicle = vehicle;
        ConsumerUnit = consumerUnit;
        Business = business;
        Bank = bank;
        Reference = reference;
        Products = products;
    }
}
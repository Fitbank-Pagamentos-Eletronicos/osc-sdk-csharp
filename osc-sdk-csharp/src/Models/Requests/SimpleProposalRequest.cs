using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;
using osc_sdk_csharp.src.Models.SubDomains;
using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.Requests;

//ProposalBankAccount
public record SimpleProposalRequest
{
    [Required]
    [JsonProperty(PropertyName = "mother")]
    public string Mother { get; set; }

    [Required]
    [JsonProperty(PropertyName = "hometownState")]
    public string HometownState { get; set; }

    [Required]
    [JsonProperty(PropertyName = "relationshipStatus")]
    public string RelationshipStatus { get; set; }

    [Required]
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }

    [Required]
    [JsonProperty(PropertyName = "business")]
    public BusinessIncome BusinessIncome { get; set; }

    [JsonProperty(PropertyName = "products")]
    public List<ProductBankAccount> Products { get; set; }

    public SimpleProposalRequest(string mother, int hometownState, int relationshipStatus, Address address, BusinessIncome businessIncome, List<ProductBankAccount> products)
    {
        Mother = mother;
        HometownState = State.GetName(hometownState);
        RelationshipStatus = Enums.RelationshipStatus.GetName(relationshipStatus);
        Address = address;
        BusinessIncome = businessIncome;
        Products = products;
    }
}
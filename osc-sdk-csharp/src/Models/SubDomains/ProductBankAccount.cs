using Newtonsoft.Json;

namespace osc_sdk_csharp.src.Models.SubDomains;
public record ProductBankAccount
{
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    [JsonProperty(PropertyName = "productId")]
    public int ProductID { get; set; }

    [JsonProperty(PropertyName = "cnpj")]
    public string? CNPJ { get; set; }

    public ProductBankAccount(string type, int productID)
    {
        Type = type;
        ProductID = productID;
    }

    public ProductBankAccount(string type, string cNPJ)
    {
        Type = type;
        CNPJ = cNPJ;
    }
}
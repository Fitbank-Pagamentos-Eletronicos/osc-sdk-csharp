using Newtonsoft.Json;

namespace osc_sdk_csharp.src.Models.SubDomains;
public record Products
{
    [JsonProperty(PropertyName = "productloan")]
    public ProductLoan? ProductLoan { get; set; }

    [JsonProperty(PropertyName = "productcard")]
    public ProductCard? ProductCard { get; set; }

    [JsonProperty(PropertyName = "productauto")]
    public ProductAuto? ProductAuto { get; set; }

    [JsonProperty(PropertyName = "producthome")]
    public ProductHome? ProductHome { get; set; }

    public Products(ProductLoan? productLoan)
    {
        ProductLoan = productLoan;
    }

    public Products(ProductCard? productCard)
    {
        ProductCard = productCard;
    }

    public Products(ProductAuto? productAuto)
    {
        ProductAuto = productAuto;
    }

    public Products(ProductHome? productHome)
    {
        ProductHome = productHome;
    }

    public Products(ProductLoan? productLoan, ProductCard? productCard, ProductAuto? productAuto, ProductHome? productHome)
    {
        ProductLoan = productLoan;
        ProductCard = productCard;
        ProductAuto = productAuto;
        ProductHome = productHome;
    }
}
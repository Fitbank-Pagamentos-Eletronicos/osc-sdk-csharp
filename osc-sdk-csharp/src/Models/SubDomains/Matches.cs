namespace osc_sdk_csharp.src.Models.SubDomains;

public record Matches
{
    public string? Name { get; set; }
    public int? ProductId { get; set; }
    public int? MinValue { get; set; }
    public int? MaxValue { get; set; }
    public int? MaxInstallment { get; set; }
    public decimal? MonthlyTax { get; set; }
    public int? MinInstallment { get; set; }
    public string? Logo { get; set; }
    public decimal? Annuity { get; set; }
    public string? Network { get; set; }

    public Matches(string? name, int? productId, int? minValue, int? maxValue, int? maxInstallment, decimal? monthlyTax, int? minInstallment, string? logo, decimal? annuity, string? network)
    {
        Name = name;
        ProductId = productId;
        MinValue = minValue;
        MaxValue = maxValue;
        MaxInstallment = maxInstallment;
        MonthlyTax = monthlyTax;
        MinInstallment = minInstallment;
        Logo = logo;
        Annuity = annuity;
        Network = network;
    }
}
using osc_sdk_csharp.src.Enums;

namespace osc_sdk_csharp.src.Models.SubDomains;
public record BankAccount
{
    public string CustomerServiceNumber { get; set; }
    public string Product { get; set; }
    public int ProductId { get; set; }
    public bool HasDocuments { get; set; }
    public bool HasContracts { get; set; }
    public CreditStatus LastStatus { get; set; }
    public string DateCreated { get; set; }
    public string LastUpdated { get; set; }

    public BankAccount(string customerServiceNumber, string product, int productId, bool hasDocuments, bool hasContracts, CreditStatus lastStatus, string dateCreated, string lastUpdated)
    {
        CustomerServiceNumber = customerServiceNumber;
        Product = product;
        ProductId = productId;
        HasDocuments = hasDocuments;
        HasContracts = hasContracts;
        LastStatus = lastStatus;
        DateCreated = dateCreated;
        LastUpdated = lastUpdated;
    }
}
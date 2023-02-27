using osc_sdk_csharp.src.Enums;
using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.SubDomains;
public record Card
{
    [Required]
    public string CustomerServiceNumber { get; set; }

    [Required]
    public ProductType Type { get; set; }

    [Required]
    public string Product { get; set; }

    [Required]
    public int ProductId { get; set; }

    [Required]
    public bool HasDocuments { get; set; }

    [Required]
    public bool HasContracts { get; set; }

    [Required]
    public string Logo { get; set; }

    [Required]
    public CreditStatus LastStatus { get; set; }
    public PendentDocuments PendentDocuments { get; set; }

    [Required]
    public string DateCreated { get; set; }

    [Required]
    public string LastUpdated { get; set; }
    public bool International { get; set; }
    public decimal Annuity { get; set; }
    public Network Network { get; set; }
    public bool PrePaid { get; set; }
    public bool DigitalAccount { get; set; }

    public Card(
        string customerServiceNumber,
        ProductType type,
        string product,
        int productId,
        bool hasDocuments,
        bool hasContracts,
        string logo,
        CreditStatus lastStatus,
        PendentDocuments pendentDocuments,
        string dateCreated,
        string lastUpdated,
        bool international,
        decimal annuity,
        Network network,
        bool prePaid,
        bool digitalAccount)
    {
        CustomerServiceNumber = customerServiceNumber;
        Type = type;
        Product = product;
        ProductId = productId;
        HasDocuments = hasDocuments;
        HasContracts = hasContracts;
        Logo = logo;
        LastStatus = lastStatus;
        PendentDocuments = pendentDocuments;
        DateCreated = dateCreated;
        LastUpdated = lastUpdated;
        International = international;
        Annuity = annuity;
        Network = network;
        PrePaid = prePaid;
        DigitalAccount = digitalAccount;
    }
}
using osc_sdk_csharp.src.Enums;
using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.SubDomains;
public record Home
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

    [Required]
    public decimal Value { get; set; }

    [Required]
    public int Installments { get; set; }

    [Required]
    public decimal MonthlyTax { get; set; }
    public decimal InstallmentsValue { get; set; }
    public decimal IOFValue { get; set; }
    public decimal GrossValue { get; set; }
    public string FirstPaymentDate { get; set; }
    public decimal CET { get; set; }
    public string ReleasedDate { get; set; }

    public Home(
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
        decimal value,
        int installments,
        decimal monthlyTax,
        decimal installmentsValue,
        decimal iOFValue,
        decimal grossValue,
        string firstPaymentDate,
        decimal cET,
        string releasedDate)
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
        Value = value;
        Installments = installments;
        MonthlyTax = monthlyTax;
        InstallmentsValue = installmentsValue;
        IOFValue = iOFValue;
        GrossValue = grossValue;
        FirstPaymentDate = firstPaymentDate;
        CET = cET;
        ReleasedDate = releasedDate;
    }
}
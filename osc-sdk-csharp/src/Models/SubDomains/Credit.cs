using osc_sdk_csharp.src.Enums;

namespace osc_sdk_csharp.src.Models.SubDomains;

public record Credit(
    string CustomerServiceNumber,
    ProductType Type,
    string Product,
    int ProductId,
    bool HasDocuments,
    bool HasContracts,
    string Logo,
    CreditStatus LastStatus,
    PendentDocuments PendentDocuments,
    string DateCreated,
    string LastUpdated);
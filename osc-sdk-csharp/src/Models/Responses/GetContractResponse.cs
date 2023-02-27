using osc_sdk_csharp.src.Models.SubDomains;

namespace osc_sdk_csharp.src.Models.Responses;

//GetContract
public record GetContractResponse(string CustomerServiceNumber, List<ContractBody> Contract);
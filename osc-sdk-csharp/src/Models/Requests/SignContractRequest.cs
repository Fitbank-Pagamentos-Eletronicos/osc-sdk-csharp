using Newtonsoft.Json;
using osc_sdk_csharp.src.Models.SubDomains;

namespace osc_sdk_csharp.src.Models.Requests;

//Contract
public record SignContractRequest
{
    [JsonProperty(PropertyName = "aceptedCheckSum")]
    public List<string> AceptedCheckSum { get; set; }

    [JsonProperty(PropertyName = "logData")]
    public LogData LogData { get; set; }

    public SignContractRequest(List<string> aceptedCheckSum, LogData logData)
    {
        AceptedCheckSum = aceptedCheckSum;
        LogData = logData;
    }
}
using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;

namespace osc_sdk_csharp.src.Models.Requests;

//Document
public class DocumentRequest
{
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    [JsonProperty(PropertyName = "mimeType")]
    public string MimeType { get; set; }

    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [JsonProperty(PropertyName = "base64")]
    public string Base64 { get; set; }

    public DocumentRequest(int type, int mimeType, string name, string base64)
    {
        Type = DocumentType.GetName(type);
        MimeType = Enums.MimeType.GetName(mimeType);
        Name = name;
        Base64 = base64;
    }
}
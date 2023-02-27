using Newtonsoft.Json;

namespace osc_sdk_csharp.src.Models.SubDomains;
public class Reference
{
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    public Reference(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }
}
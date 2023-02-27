using Newtonsoft.Json;
using osc_sdk_csharp.src.Models.SubDomains;
using System.Collections.ObjectModel;

namespace osc_sdk_csharp.src.Models.Responses;

public record Pipeline
{

    [JsonProperty(PropertyName = "id")] 
    public string Id { get; set; }

    [JsonProperty(PropertyName = "status")] 
    public string Status { get; set; }

    [JsonProperty(PropertyName = "cpf")] 
    public long Cpf { get; set; }

    [JsonProperty(PropertyName = "name")] 
    public string Name { get; set; }

    [JsonProperty(PropertyName = "dateCreated")] 
    public string DateCreated { get; set; }

    [JsonProperty(PropertyName = "lastUpdated")] 
    public string LastUpdated { get; set; }

    [JsonProperty(PropertyName = "matches")]
    public Collection<Matches> Matches { get; set; }

    [JsonProperty(PropertyName = "proposals")]
    public Proposals Proposals { get; set; }

    public Pipeline(string id, string status, long cpf, string name, string dateCreated, string lastUpdated, Collection<Matches> matches, Proposals proposals)
    {
        Id = id;
        Status = status;
        Cpf = cpf;
        Name = name;
        DateCreated = dateCreated;
        LastUpdated = lastUpdated;
        Matches = matches;
        Proposals = proposals;
    }
}
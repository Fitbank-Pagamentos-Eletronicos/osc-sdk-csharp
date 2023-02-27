using Newtonsoft.Json;

namespace osc_sdk_csharp.src.Models.SubDomains;

public record ServiceAccount
{
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    [JsonProperty(PropertyName = "project_id")]
    public string ProjectId { get; set; }

    [JsonProperty(PropertyName = "private_key_id")]
    public string PrivateKeyId { get; set; }

    [JsonProperty(PropertyName = "private_key")]
    public string PrivateKey { get; set; }

    [JsonProperty(PropertyName = "client_email")]
    public string ClientEmail { get; set; }

    [JsonProperty(PropertyName = "client_id")]
    public string ClientId { get; set; }

    [JsonProperty(PropertyName = "auth_uri")]
    public string AuthUrl { get; set; }

    [JsonProperty(PropertyName = "token_uri")]
    public string TokenUrl { get; set; }

    [JsonProperty(PropertyName = "auth_provider_x509_cert_url")]
    public string AuthProviderX509CertUrl { get; set; }

    [JsonProperty(PropertyName = "client_x509_cert_url")]
    public string ClientX509CertUrl { get; set; }

    public ServiceAccount(
        string type,
        string projectId,
        string privateKeyId,
        string privateKey,
        string clientEmail,
        string clientId,
        string authUrl,
        string tokenUrl,
        string authProviderX509CertUrl,
        string clientX509CertUrl)
    {
        Type = type;
        ProjectId = projectId;
        PrivateKeyId = privateKeyId;
        PrivateKey = privateKey;
        ClientEmail = clientEmail;
        ClientId = clientId;
        AuthUrl = authUrl;
        TokenUrl = tokenUrl;
        AuthProviderX509CertUrl = authProviderX509CertUrl;
        ClientX509CertUrl = clientX509CertUrl;
    }
}

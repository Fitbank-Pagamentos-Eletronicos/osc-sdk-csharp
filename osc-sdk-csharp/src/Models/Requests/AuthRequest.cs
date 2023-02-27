using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.Requests;

//Authorization
public record AuthRequest
{
    [Required]
    private string ClientId { get; init; }

    [Required]
    private string ClientSecret { get; init; }

    [Required]
    private string Scopes { get; init; }

    public AuthRequest(string clientId, string clientSecret, string scopes)
    {
        ClientId = clientId;
        ClientSecret = clientSecret;
        Scopes = scopes;
    }
}

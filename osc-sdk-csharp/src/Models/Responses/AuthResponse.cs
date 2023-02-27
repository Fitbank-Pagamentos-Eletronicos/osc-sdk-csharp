using System.ComponentModel.DataAnnotations;

namespace osc_sdk_csharp.src.Models.Responses;

//AuthSuccess
public record AuthResponse
{
    [Required]
    public string? AccessToken { get; set; }

    [Required]
    public string? ExpireAt { get; set; }

    public AuthResponse( ){ }

    public AuthResponse(string accessToken, string expireAt)
    {
        AccessToken = accessToken;
        ExpireAt = expireAt;
    }
}
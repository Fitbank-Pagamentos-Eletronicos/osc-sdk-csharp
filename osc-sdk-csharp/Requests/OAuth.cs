using osc_sdk_csharp.src.Enums;
using RestSharp;
using System.Text.RegularExpressions;

namespace osc_sdk_csharp.Requests;
internal class OAuth
{
    public static string AuthRequest(string clientId, string clientSecret)
    {
        try
        {
            var client = new RestClient(URLSettings.GetURL("AuthRequest"));
            client.Options.MaxTimeout = -1;
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", clientId);
            request.AddParameter("client_secret", clientSecret);
            request.AddParameter("scope", "api-external");
            RestResponse response = client.Execute(request);
            string content = response.Content!;
            content = Regex.Replace(content, @"\\", "");
            content = content.Replace("access_token", "AccessToken");
            content = content.Replace("expire_at", "ExpireAt");
            return content;
        }
        catch(Exception)
        {
            throw;
        }
    }
}

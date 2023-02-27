using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;
using osc_sdk_csharp.src.Models.Requests;
using RestSharp;
using Formatting = Newtonsoft.Json.Formatting;

namespace osc_sdk_csharp.Requests;

internal class OSignUp
{
    public static string SignUpRequest(SignupRequest signUpRequest, string token)
    {
        try
        {
            var client = new RestClient(URLSettings.GetURL("SignUpRequest"));
            client.Options.MaxTimeout = -1;

            var request = new RestRequest( );
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", String.Join(" ", "Bearer", token));
            string body = JsonConvert.SerializeObject(signUpRequest, Formatting.Indented);
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            RestResponse response = client.Execute(request);

            if(String.IsNullOrEmpty(response.Content))
                throw new HttpRequestException("A resposta da requisição foi nula");

            string content = response.Content.Replace("\\", "");
            return content;
        }
        catch(Exception)
        {
            throw;
        }
    }
    public static string SimpleSignUpRequest(SimpleSignupRequest signUpRequest, string token)
    {
        try
        {
            var client = new RestClient(URLSettings.GetURL("SimpleSignUpRequest"));
            client.Options.MaxTimeout = -1;

            var request = new RestRequest( );
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", String.Join(" ", "Bearer", token));
            string body = JsonConvert.SerializeObject(signUpRequest, Formatting.Indented);
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            RestResponse response = client.Execute(request);

            if(String.IsNullOrEmpty(response.Content))
                throw new HttpRequestException("A resposta da requisição foi nula");

            string content = response.Content.Replace("\\", "");
            return content;
        }
        catch(Exception)
        {
            throw;
        }
    }
}

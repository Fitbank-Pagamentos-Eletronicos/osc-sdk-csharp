using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;
using osc_sdk_csharp.src.Models.Responses;
using RestSharp;
using osc_sdk_csharp.src.Models.Requests;

namespace osc_sdk_csharp.Requests;

internal class OContract
{
    public static string SignContractRequest(SignContractRequest contractRequest, string token, string customerServiceNumber)
    {
        try
        {
            var client = new RestClient(URLSettings.GetURL("SignContractRequest") + customerServiceNumber);
            client.Options.MaxTimeout = -1;

            var request = new RestRequest( );
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", String.Join(" ", "Bearer", token));
            string body = JsonConvert.SerializeObject(contractRequest, Formatting.Indented);
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

    public static string GetContractRequest(string token, string customerServiceNumber)
    {
        try
        {
            var client = new RestClient(URLSettings.GetURL("SignContractRequest") + customerServiceNumber);
            client.Options.MaxTimeout = -1;

            var request = new RestRequest( );
            request.Method = Method.Get;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", String.Join(" ", "Bearer", token));

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

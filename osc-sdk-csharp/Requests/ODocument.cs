using Newtonsoft.Json;
using osc_sdk_csharp.src.Enums;
using osc_sdk_csharp.src.Models.Responses;
using RestSharp;
using osc_sdk_csharp.src.Models.Requests;

namespace osc_sdk_csharp.Requests;

internal class ODocument
{
    public static string DocumentRequest(DocumentRequest proposalRequest, string token, string id)
    {
        try
        {
            var client = new RestClient(URLSettings.GetURL("DocumentRequest") + id);
            client.Options.MaxTimeout = -1;

            var request = new RestRequest( );
            request.Method = Method.Put;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", String.Join(" ", "Bearer", token));
            string body = JsonConvert.SerializeObject(proposalRequest, Formatting.Indented);
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

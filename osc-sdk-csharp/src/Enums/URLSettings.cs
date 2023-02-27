namespace osc_sdk_csharp.src.Enums;

internal class URLSettings
{
    private static KeyValuePair<string, string> CreateURL(string method)
    {
        IDictionary<string, string> url = new Dictionary<string, string>
        {
            { "AuthRequest", "https://auth.easycredito.com.br/client/auth" },
            { "SignUpRequest", "https://demo-api.easycredito.com.br/api/external/v2.1/process/signup" },
            { "SimpleSignUpRequest", "https://demo-api.easycredito.com.br/api/external/v2.1/process/simple_signup" },
            { "ProposalRequest", "https://demo-api.easycredito.com.br/api/external/v2.1/process/proposal/" },
            { "SimpleProposalRequest", "https://demo-api.easycredito.com.br/api/external/v2.1/process/simple_proposal/" },
            { "DocumentRequest", "https://demo-api.easycredito.com.br/api/external/v2/process/document/" },
            { "SignContractRequest", "https://demo-api.easycredito.com.br/api/external/v2.1/contract/" },
            { "GetPubSub", "https://staging-api.easycredito.com.br/api/external/v2.1/pubsub" }
        };

        if (string.IsNullOrEmpty(method) || !url.ContainsKey(method))
            throw new ArgumentNullException("URL inexistente!");

        return url.SingleOrDefault(p => p.Key == method);
    }
    public static string GetURL(string method)
    {
        var url = CreateURL(method);

        return url.Value;
    }
}

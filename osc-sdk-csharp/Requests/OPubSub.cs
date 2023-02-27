using Google.Apis.Auth.OAuth2;
using Google.Cloud.PubSub.V1;
using Grpc.Auth;
using osc_sdk_csharp.src.Enums;
using osc_sdk_csharp.src.Models.Responses;
using RestSharp;

namespace osc_sdk_csharp.Requests;

internal class OPubSub
{
    public static string GetPubSub(string token)
    {
        try
        {
            var client = new RestClient(URLSettings.GetURL("GetPubSub"));
            client.Options.MaxTimeout = -1;

            var request = new RestRequest( );
            request.Method = Method.Get;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", String.Join(" ", "Bearer", token));

            RestResponse response = client.Execute(request);

            if(String.IsNullOrEmpty(response.Content))
                throw new HttpRequestException("A resposta da requisição foi nula");

            return response.Content;
        }
        catch(Exception)
        {
            throw;
        }
    }

    public static Task PubSubSubscriber(PubSubResponse config, Func<string, bool> messageHandler)
    {
        SubscriptionName subscriptionName = SubscriptionName.FromProjectSubscription(config.ProjectId, config.SubscriptionId);
        var credential = GoogleCredential.FromJson(config.ServiceAccount);
        
        SubscriberClientBuilder builder = new SubscriberClientBuilder();
        builder.SubscriptionName = subscriptionName;
        builder.ChannelCredentials = credential.ToChannelCredentials();
        SubscriberClient subscriber = builder.Build();

        Task startTask = subscriber.StartAsync((PubsubMessage message, CancellationToken cancel) =>
        {
            messageHandler(message.Data.ToStringUtf8());
            return Task.FromResult(SubscriberClient.Reply.Ack);
        });

        return startTask;
    }
}

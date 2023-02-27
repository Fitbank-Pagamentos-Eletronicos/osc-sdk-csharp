using Newtonsoft.Json;

namespace osc_sdk_csharp.src.Models.Responses;

public record PubSubResponse
{
    [JsonProperty(PropertyName = "topic_id")]
    public string TopicId { get; set; }

    [JsonProperty(PropertyName = "subscription_id")]
    public string SubscriptionId { get; set; }

    [JsonProperty(PropertyName = "project_id")]
    public string ProjectId { get; set; }

    [JsonProperty(PropertyName = "service_account")]
    public string ServiceAccount { get; set; }

    public PubSubResponse(string topicId, string subscriptionId, string projectId, string serviceAccount)
    {
        TopicId = topicId;
        SubscriptionId = subscriptionId;
        ProjectId = projectId;
        ServiceAccount = serviceAccount;
    }
}

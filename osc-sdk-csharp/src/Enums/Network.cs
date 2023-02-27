namespace osc_sdk_csharp.src.Enums;
public class Network
{
    private static KeyValuePair<int, string> CreateNetwork(int? key, string? value)
    {
        try
        {
            IDictionary<int, string> network = new Dictionary<int, string>
            {
                { 0, "VISA" },
                { 1, "MASTERCARD" },
                { 2, "ELO" }
            };

            if(!string.IsNullOrEmpty(value))
            {
                if(!network.Values.Contains(value))
                {
                    throw new ArgumentNullException(GetName(value));
                } else
                {
                    return network.SingleOrDefault(p => p.Key == 0);
                }

            }

            return network.SingleOrDefault(p => p.Key == key);
        }
        catch(Exception)
        {

            throw;
        }
    }
    public static string GetName(int key)
    {
        var network = CreateNetwork(key, null);

        return network.Value;
    }

    public static string GetName(string value)
    {
        var network = CreateNetwork(null, value);

        return value;
    }
}
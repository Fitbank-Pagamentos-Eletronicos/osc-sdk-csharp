namespace osc_sdk_csharp.src.Enums;
public class HomeSince
{
    private static KeyValuePair<int, string> CreateHomeSince(int key)
    {
        IDictionary<int, string> homeSince = new Dictionary<int, string>( );
        homeSince.Add(0, "MENOR_6_MESES");
        homeSince.Add(1, "MENOR_1_ANO");
        homeSince.Add(2, "MENOR_2_ANOS");
        homeSince.Add(3, "MAIOR_2_ANOS");

        return homeSince.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var homeSince = CreateHomeSince(key);

        return homeSince.Value;
    }
}
namespace osc_sdk_csharp.src.Enums;
public class HomeType
{
    private static KeyValuePair<int, string> CreateHomeType(int key)
    {
        IDictionary<int, string> homeType = new Dictionary<int, string>( );
        homeType.Add(0, "ALUGADA");
        homeType.Add(1, "PARENTES");
        homeType.Add(2, "FUNCIONAL");
        homeType.Add(3, "PROPRIA_QUITADA");
        homeType.Add(4, "PROPRIA_FINANCIADA");
        homeType.Add(5, "OUTROS");

        return homeType.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var homeType = CreateHomeType(key);

        return homeType.Value;
    }
}
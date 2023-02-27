namespace osc_sdk_csharp.src.Enums;

public class Nationality
{
    private static KeyValuePair<int, string> CreateNationality(int key)
    {
        IDictionary<int, string> nationality = new Dictionary<int, string>( );
        nationality.Add(0, "BRASILEIRO");
        nationality.Add(1, "ESTRANGEIRO");

        return nationality.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var nationality = CreateNationality(key);

        return nationality.Value;
    }
}
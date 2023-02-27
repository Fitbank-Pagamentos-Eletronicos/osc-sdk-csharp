namespace osc_sdk_csharp.src.Enums;
public class IdentityType
{
    private static KeyValuePair<int, string> CreateIdentityType(int key)
    {
        IDictionary<int, string> identityType = new Dictionary<int, string>( );
        identityType.Add(0, "RG");
        identityType.Add(1, "CNH");
        identityType.Add(2, "PASSAPORTE");
        identityType.Add(3, "CARTEIRA_CRC");
        identityType.Add(4, "CARTEIRA_CREA");
        identityType.Add(5, "CARTEIRA_OAB");
        identityType.Add(6, "CARTEIRA_CRE");

        return identityType.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var identityType = CreateIdentityType(key);

        return identityType.Value;
    }
}
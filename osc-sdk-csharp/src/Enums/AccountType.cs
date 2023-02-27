namespace osc_sdk_csharp.src.Enums;
public class AccountType
{
    private static KeyValuePair<int, string> CreateAccountType(int key)
    {
        IDictionary<int, string> accountType = new Dictionary<int, string>( );
        accountType.Add(0, "CONTA_CORRENTE_INDIVIDUAL");
        accountType.Add(1, "CONTA_CORRENTE_CONJUNTA");
        accountType.Add(2, "CONTA_POUPANCA_CONJUNTA");
        accountType.Add(3, "CONTA_POUPANCA_INDIVIDUAL ");

        return accountType.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var accountType = CreateAccountType(key);

        return accountType.Value;
    }
}
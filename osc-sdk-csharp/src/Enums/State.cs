namespace osc_sdk_csharp.src.Enums;
public class State
{
    private static KeyValuePair<int, string> CreateState(int key)
    {
        IDictionary<int, string> state = new Dictionary<int, string>( );
        state.Add(0, "AC");
        state.Add(1, "AL");
        state.Add(2, "AP");
        state.Add(3, "AM");
        state.Add(4, "BA");
        state.Add(5, "CE");
        state.Add(6, "DF");
        state.Add(7, "ES");
        state.Add(8, "GO");
        state.Add(9, "MA");
        state.Add(10, "MT");
        state.Add(11, "MS");
        state.Add(12, "MG");
        state.Add(13, "PA");
        state.Add(14, "PB");
        state.Add(15, "PR");
        state.Add(16, "PE");
        state.Add(17, "PI");
        state.Add(18, "RJ");
        state.Add(19, "RN");
        state.Add(20, "RS");
        state.Add(21, "RO");
        state.Add(22, "RR");
        state.Add(23, "SC");
        state.Add(24, "SP");
        state.Add(25, "SE");
        state.Add(26, "TO");

        return state.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var state = CreateState(key);

        return state.Value;
    }
}
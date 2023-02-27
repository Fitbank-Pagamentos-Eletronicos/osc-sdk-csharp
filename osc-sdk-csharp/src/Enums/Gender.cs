namespace osc_sdk_csharp.src.Enums;
public class Gender
{
    private static KeyValuePair<int, string> CreateGender(int key)
    {
        IDictionary<int, string> genders = new Dictionary<int, string>( );
        genders.Add(0, "MASCULINO");
        genders.Add(1, "FEMININO");

        return genders.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var gender = CreateGender(key);

        return gender.Value;
    }
}
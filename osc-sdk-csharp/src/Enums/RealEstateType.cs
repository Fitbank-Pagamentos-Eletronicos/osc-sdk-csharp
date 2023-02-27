namespace osc_sdk_csharp.src.Enums;
public class RealEstateType
{
    private static KeyValuePair<int, string> CreateRealEstateType(int key)
    {
        IDictionary<int, string> realEstateType = new Dictionary<int, string>( );
        realEstateType.Add(0, "HOUSE");
        realEstateType.Add(1, "APARTAMENT");
        realEstateType.Add(2, "COMMERCIAL");
        realEstateType.Add(3, "LAND");
        realEstateType.Add(4, "OTHERS");

        return realEstateType.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var realEstateType = CreateRealEstateType(key);

        return realEstateType.Value;
    }
}
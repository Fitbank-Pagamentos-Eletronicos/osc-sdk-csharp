namespace osc_sdk_csharp.src.Enums;
public class ProductType
{
    private static KeyValuePair<int, string> CreateProductType(int key)
    {
        IDictionary<int, string> productType = new Dictionary<int, string>
        {
            { 0, "LOAN" },
            { 1, "CARD" },
            { 2, "REFINANCING_AUTO" },
            { 3, "REFINANCING_HOME" },
            { 4, "CAAS" },
            { 5, "WORKING_CAPITAL" }
        };

        return productType.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var productType = CreateProductType(key);

        return productType.Value;
    }
}
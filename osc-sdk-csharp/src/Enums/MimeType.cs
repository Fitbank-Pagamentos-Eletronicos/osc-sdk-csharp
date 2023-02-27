namespace osc_sdk_csharp.src.Enums;

public class MimeType
{
    private static KeyValuePair<int, string> CreateMimeType(int key)
    {
        IDictionary<int, string> mimeType = new Dictionary<int, string>( );
        mimeType.Add(0, "image/jpeg");
        mimeType.Add(1, "image/png");
        mimeType.Add(2, "application/pdf");

        return mimeType.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var mimeType = CreateMimeType(key);

        return mimeType.Value;
    }
}
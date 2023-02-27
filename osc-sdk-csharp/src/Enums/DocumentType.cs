namespace osc_sdk_csharp.src.Enums;
public class DocumentType
{
    private static KeyValuePair<int, string> CreateDocumentType(int key)
    {
        IDictionary<int, string> documentType = new Dictionary<int, string>( );
        documentType.Add(0, "SELF");
        documentType.Add(1, "IDENTITY_FRONT");
        documentType.Add(2, "IDENTITY_BACK");
        documentType.Add(3, "ADDRESS_PROOF ");
        documentType.Add(4, "INCOME_PROOF ");

        return documentType.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var documentType = CreateDocumentType(key);

        return documentType.Value;
    }
}
namespace osc_sdk_csharp.src.Enums;
public class RelationshipStatus
{
    private static KeyValuePair<int, string> CreateRelationshipStatus(int key)
    {
        IDictionary<int, string> relationshipStatus = new Dictionary<int, string>( );
        relationshipStatus.Add(0, "CASADO");
        relationshipStatus.Add(1, "DIVORCIADO");
        relationshipStatus.Add(2, "VIUVO");
        relationshipStatus.Add(3, "SEPARADO");
        relationshipStatus.Add(4, "SOLTEIRO");
        relationshipStatus.Add(5, "COMPANHEIRO");
        relationshipStatus.Add(6, "UNIAO_ESTAVEL");
        relationshipStatus.Add(7, "SEPARADO_JUDICIALMENTE");

        return relationshipStatus.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var relationshipStatus = CreateRelationshipStatus(key);

        return relationshipStatus.Value;
    }
}
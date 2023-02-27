namespace osc_sdk_csharp.src.Enums;

public class Occupation
{
    private static KeyValuePair<int, string> CreateOccupation(int key)
    {
        IDictionary<int, string> educations = new Dictionary<int, string>( );
        educations.Add(0, "APOSENTADO");
        educations.Add(1, "PENSIONISTA");
        educations.Add(2, "AUTONOMO");
        educations.Add(3, "EMPRESARIO");
        educations.Add(4, "PRODISSIONAL_LIBERAL");
        educations.Add(5, "ASSALARIADO");
        educations.Add(6, "FUNCIONARIO_PUBLICO");
        educations.Add(7, "DESEMPREGADO");

        return educations.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var occupation = CreateOccupation(key);

        return occupation.Value;
    }
}
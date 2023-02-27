namespace osc_sdk_csharp.src.Enums;
public class Education
{
    private static KeyValuePair<int, string> CreateEducation(int key)
    {
        IDictionary<int, string> educations = new Dictionary<int, string>();
        educations.Add(0, "NAO_ALFABETIZADO");
        educations.Add(1, "ENSINO_FUNDAMENTAL_INCOMPLETO");
        educations.Add(2, "ENSINO_FUNDAMENTAL_COMPLETO");
        educations.Add(3, "ENSINO_MEDIO_INCOMPLETO");
        educations.Add(4, "ENSINO_MEDIO_COMPLETO");
        educations.Add(5, "ENSINO_SUPERIOR_INCOMPLETO");
        educations.Add(6, "ENSINO_SUPERIOR_COMPLETO");
        educations.Add(7, "POS_GRADUACAO");

        return educations.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var education = CreateEducation(key);

        return education.Value;
    }
}
namespace osc_sdk_csharp.src.Enums;

public class IdentityIssuer
{
    private static KeyValuePair<int, string> CreateIdentityIssuer(int key)
    {
        IDictionary<int, string> identityIssuer = new Dictionary<int, string>( );
        identityIssuer.Add(0, "SSP");
        identityIssuer.Add(1, "DETRAN");
        identityIssuer.Add(2, "CONS_REG_ECONOMIA");
        identityIssuer.Add(3, "MIN_EXERCITO");
        identityIssuer.Add(4, "OAB");
        identityIssuer.Add(5, "CREA");
        identityIssuer.Add(6, "SJS");
        identityIssuer.Add(7, "CTPS");
        identityIssuer.Add(8, "CREME");
        identityIssuer.Add(9, "MINEX");
        identityIssuer.Add(10, "CRM");
        identityIssuer.Add(11, "SJTC");
        identityIssuer.Add(12, "MAER");
        identityIssuer.Add(13, "DPF");
        identityIssuer.Add(14, "RBF");
        identityIssuer.Add(15, "IML");
        identityIssuer.Add(16, "CPROF");
        identityIssuer.Add(17, "CRO");
        identityIssuer.Add(18, "CRC");
        identityIssuer.Add(19, "DPMAF");
        identityIssuer.Add(20, "ME");
        identityIssuer.Add(21, "BM");
        identityIssuer.Add(22, "AERON");
        identityIssuer.Add(23, "SJT");
        identityIssuer.Add(24, "COREN");
        identityIssuer.Add(25, "DETRA");
        identityIssuer.Add(26, "EXERC");
        identityIssuer.Add(27, "SSI");
        identityIssuer.Add(28, "MINISTERIO_DA_MARINHA");
        identityIssuer.Add(29, "CRA_CONSELHO_ADMINISTRATIVO");
        identityIssuer.Add(30, "INSTITUTO_FELIX_PACHECO");
        identityIssuer.Add(31, "INST_NAC_PROPRIEDADE_INDUSTRIA");
        identityIssuer.Add(32, "MINISTERIO_DA_FAZENDA");
        identityIssuer.Add(33, "TRIBUNAL_REGIONAL_DO_TRABALHO");
        identityIssuer.Add(34, "CONSELHO_REGIONAL_PSICOLOGIA");
        identityIssuer.Add(35, "POLICIA_MILITAR");

        return identityIssuer.SingleOrDefault(p => p.Key == key);
    }
    public static string GetName(int key)
    {
        var identityIssuer = CreateIdentityIssuer(key);

        return identityIssuer.Value;
    }
}
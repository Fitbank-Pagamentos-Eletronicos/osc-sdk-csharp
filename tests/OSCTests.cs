using Newtonsoft.Json;
using osc_sdk_csharp;
using osc_sdk_csharp.src.Models.Requests;
using osc_sdk_csharp.src.Models.Responses;
using osc_sdk_csharp.src.Models.SubDomains;
using Xunit.Abstractions;

namespace tests;

public class OSCTests
{
    private readonly ITestOutputHelper output;

    public OSCTests(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void TestSignupExemple( )
    {
        OSC instance = OSC.CreateInstance("", "")!;

        SimpleSignupRequest data = new SimpleSignupRequest(
            "111.111.111-11",
            "Carlos Henrique",
            "2002-01-19",
            "email@email.com",
            "10987654321",
            "74180040",
            new LogData(
                -16.678,
                -49.256,
                "2019-08-21T14:31:17.459Z",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.142 Safari/537.36",
                "0.0.0.0",
                null
            )
        );

        Pipeline pipeline = instance.SimpleSignUp(data);

        output.WriteLine("resp: {0}", pipeline.Id);
    }

    [Fact]
    public void TestPipelineExemple( )
    {

        string data = "{\"id\": \"20190805062216\",\"status\": \"SIGNUP_COMPLETED\",\"cpf\": 191,\"name\": \"Fulano d'Tal\",\"dateCreated\": \"2020-10-28T13:50:21.024Z\",\"lastUpdated\": \"2020-10-28T13:50:21.024Z\",\"matches\": [{\"name\": \"EMPR�STIMO PESSOAL\",\"productId\": 1234234,\"minValue\": 500,\"maxValue\": 50000,\"maxInstallment\": 36,\"monthlyTax\": 0.059,\"minInstallment\": 12,\"logo\": \"url\"},{\"name\": \"CART�O DE CREDITO - Visa Platinum\",\"productId\": 1234234,\"annuity\": 499.92,\"network\": \"VISA\",\"logo\": \"url\"},{\"name\": \"REFINANCIAMENTO DE VEICULOS\",\"productId\": 1234234,\"minValue\": 25000,\"maxValue\": 50000,\"maxInstallment\": 48,\"monthlyTax\": 0.059,\"minInstallment\": 12,\"logo\": \"url\"},{\"name\": \"REFINANCIAMENTO CASA\",\"productId\": 1234234,\"minValue\": 25000,\"maxValue\": 150000,\"maxInstallment\": 124,\"monthlyTax\": 1.059,\"minInstallment\": 12,\"logo\": \"url\"}]}";

        Pipeline pipeline = JsonConvert.DeserializeObject<Pipeline>(data)!;

        output.WriteLine("resp: {0}", pipeline);
        foreach(var match in pipeline.Matches)
        {
            output.WriteLine("Match: {0}", match);
        }
    }
}
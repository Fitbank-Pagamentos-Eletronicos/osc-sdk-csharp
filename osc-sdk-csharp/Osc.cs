using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using osc_sdk_csharp.Requests;
using osc_sdk_csharp.src.Models.Responses;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Validator = osc_sdk_csharp.Utils.Validator;
using osc_sdk_csharp.src.Models.Requests;

namespace osc_sdk_csharp;

public class OSC
{
    private static readonly List<OSC> Instances = new List<OSC>( );
    private static readonly string DefaultName = "default";
    
    [Required]
    private string Name { get; init; }
    [Required]
    private string ClientId { get; init; }
    [Required]
    private string ClientSecret { get; init; }
    
    private string? AccessToken { get; set; }
    private DateTime? ExpireAt { get; set; }

    public OSC(string name, string clientId, string clientSecret)
    {
        this.Name = name;
        this.ClientId = clientId;
        this.ClientSecret = clientSecret;
    }

    public static OSC? CreateInstance(string clientId, string clientSecret)
    {
        return OSC.CreateInstance(DefaultName, clientId, clientSecret);
    }
    public static OSC? CreateInstance(string name, string clientId, string clientSecret)
    {
        Validator.Validate(clientId!, clientSecret!);

        string normalized = Normalize(name);

        OSC? instance = GetInstance(normalized);
        if (instance is not null)
        {
            if (instance.ClientId == clientId && instance.ClientSecret == clientSecret)
            {
                return instance;
            }
            return null;
        }

        instance = new OSC(normalized, clientId, clientSecret);
        Instances.Add(instance);
        return instance;
    }
    
    public static OSC? GetInstance(string? name)
    {
        string normalized = Normalize(name!);
        return Instances.Find(x => x.Name == normalized)!;
    }
    
    public static string Normalize(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            str = DefaultName;
        }
        
        str = Regex.Replace(str, @"[^a-zA-Z0-9ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç\s]", "-", RegexOptions.None);
        str = Regex.Replace(str, @"[Çç]", "c", RegexOptions.None);
        str = str.ToLower();

        StringBuilder stringRetunr = new StringBuilder( );
        var arrayText = str.Normalize(NormalizationForm.FormD).ToCharArray( );
        foreach(char letter in arrayText)
        {
            if(CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
            {
                stringRetunr.Append(letter);
            }
        }
        return stringRetunr.ToString( );
    }
    
    public string GetToken()
    {
        if (string.IsNullOrEmpty(this.AccessToken) || this.ExpireAt is null || this.ExpireAt < DateTime.Now)
        {
            AuthResponse auth = this.Auth();
            this.AccessToken = auth.AccessToken;
            this.ExpireAt = DateTime.Parse(auth.ExpireAt!);
        }

        return this.AccessToken;
    }
    
    public AuthResponse Auth()
    {
        string jsonString = OAuth.AuthRequest(this.ClientId, this.ClientSecret);
        AuthResponse response = JsonConvert.DeserializeObject<AuthResponse>(jsonString)!;
        return response;
    }
    public Pipeline SignUp(SignupRequest request)
    {
        Validator.Validate(request);
        string jsonString = OSignUp.SignUpRequest(request, this.GetToken());
        Pipeline response = JsonConvert.DeserializeObject<Pipeline>(jsonString)!;
        return response;
    }
    public Pipeline SimpleSignUp(SimpleSignupRequest request)
    {
        Validator.Validate(request);
        string jsonString = OSignUp.SimpleSignUpRequest(request, this.GetToken());
        Pipeline response = JsonConvert.DeserializeObject<Pipeline>(jsonString)!;
        return response;
    }
    public Pipeline Proposal(ProposalRequest request, string id)
    {
        Validator.Validate(request);
        string jsonString = OProposal.ProposalRequest(request, this.GetToken(), id);
        Pipeline response = JsonConvert.DeserializeObject<Pipeline>(jsonString)!;
        return response;
    }
    public Pipeline SimpleProposal(SimpleProposalRequest request, string id)
    {
        Validator.Validate(request);
        string jsonString = OProposal.SimpleProposalRequest(request, this.GetToken(), id);
        Pipeline response = JsonConvert.DeserializeObject<Pipeline>(jsonString)!;
        return response;
    }
    public DocumentResponse Document(DocumentRequest request, string id)
    {
        Validator.Validate(request);
        string jsonString = ODocument.DocumentRequest(request, this.GetToken(), id);
        DocumentResponse response = JsonConvert.DeserializeObject<DocumentResponse>(jsonString)!;
        return response;
    }
    public SignContractResponse SignContract(SignContractRequest request, string customerServiceNumber)
    {
        Validator.Validate(request);
        string jsonString = OContract.SignContractRequest(request, this.GetToken(), customerServiceNumber);
        SignContractResponse response = JsonConvert.DeserializeObject<SignContractResponse>(jsonString)!;
        return response;
    }
    public GetContractResponse GetContract(string customerServiceNumber)
    {
        string jsonString = OContract.GetContractRequest(this.GetToken(), customerServiceNumber);
        GetContractResponse response = JsonConvert.DeserializeObject<GetContractResponse>(jsonString)!;
        return response;
    }
    public void SetResponseListening(Func<Pipeline, bool> handler)
    {
        string jsonConfig = OPubSub.GetPubSub(this.GetToken());
        PubSubResponse config = JsonConvert.DeserializeObject<PubSubResponse>(jsonConfig)!;
        
        OPubSub.PubSubSubscriber(config, (jsonString) => {
            Pipeline response = JsonConvert.DeserializeObject<Pipeline>(jsonString)!;
            return handler(response);
        });
    }
}

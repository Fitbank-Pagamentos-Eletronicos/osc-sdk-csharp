using osc_sdk_csharp.src.Enums;
using osc_sdk_csharp.src.Models.Requests;
using osc_sdk_csharp.src.Models.Responses;

namespace osc_sdk_csharp.Utils;

internal class Validator
{
    public static void Validate(string clientId, string clientSecret)
    {
        if(clientId == null)
            throw new ArgumentNullException(nameof(clientId), "Id de usuário não pode ser nulo");

        if(clientSecret == null)
            throw new ArgumentNullException(nameof(clientSecret), "Chave Secret de usuário não pode ser nulo");
    }
    public static void Validate(string clientId, string clientSecret, Scopes scope)
    {
        if(clientId == null)
            throw new ArgumentNullException(nameof(clientId), "Id de usuário não pode ser nulo");

        if(clientSecret == null)
            throw new ArgumentNullException(nameof(clientSecret), "Chave Secret de usuário não pode ser nulo");

        if(scope < 0)
            throw new ArgumentNullException(nameof(scope), "Escopo da aplicação não pode ser nulo");
    }
    public static void Validate(AuthResponse token)
    {
        if(token == null)
            throw new ArgumentNullException(nameof(token), "Autorização não realizada!");

        if(token.AccessToken == null)
            throw new ArgumentNullException(nameof(token.AccessToken), "Token de acesso não pode ser nulo");

        if(token.ExpireAt == null)
            throw new ArgumentNullException(nameof(token.ExpireAt), "Data de expiração não pode ser nula");
    }
    public static void Validate(SignupRequest signUp)
    {
        if(signUp == null)
            throw new ArgumentNullException(nameof(signUp), "Requisição não pode ser nula!");

        if(String.IsNullOrEmpty(signUp.CPF))
            throw new ArgumentNullException(nameof(signUp.CPF), "CPF não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.Name))
            throw new ArgumentNullException(nameof(signUp.Name), "Nome não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.Birthday))
            throw new ArgumentNullException(nameof(signUp.Birthday), "Data de nascimento não pode ser nula!");

        if(String.IsNullOrEmpty(signUp.Email))
            throw new ArgumentNullException(nameof(signUp.Email), "E-Mail não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.Phone))
            throw new ArgumentNullException(nameof(signUp.Phone), "Número de telefone não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.ZipCode))
            throw new ArgumentNullException(nameof(signUp.ZipCode), "CEP não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.Education))
            throw new ArgumentNullException(nameof(signUp.Education), "Education não pode ser nulo!");

        if(signUp.Banks == null)
            throw new ArgumentNullException(nameof(signUp.Banks), "Instituição bancária não pode ser nula!");

        if(String.IsNullOrEmpty(signUp.Occupation))
            throw new ArgumentNullException(nameof(signUp.Occupation), "Occupation não pode ser nulo!");

        if(signUp.Income < 1000)
            throw new ArgumentNullException(nameof(signUp.Income), "Renda não pode ser menor que R$: 1.000,00!");

        if(signUp.Income > 50000)
            throw new ArgumentNullException(nameof(signUp.Income), "Renda não pode ser maior que R$: 50.000,00!");

        if((signUp.Products == null) || (!signUp.Products.Any( )))
            throw new ArgumentNullException(nameof(signUp.Products), "Lista de produtos não pode ser nula!");

        if(signUp.LogData == null)
            throw new ArgumentNullException(nameof(signUp.LogData), "Instituição bancária não pode ser nula!");

        if(signUp.LogData.Latitude > 90 || signUp.LogData.Latitude < -90)
            throw new ArgumentNullException(nameof(signUp.LogData.Latitude), "Latitude fora do padrão!");

        if(signUp.LogData.Longitude > 180 || signUp.LogData.Longitude < -180)
            throw new ArgumentNullException(nameof(signUp.LogData), "Longitude fora do padrão!");

        if(String.IsNullOrEmpty(signUp.LogData.UserAgent))
            throw new ArgumentNullException(nameof(signUp.LogData.UserAgent), "Parâmetro UserAgent não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.LogData.IP))
            throw new ArgumentNullException(nameof(signUp.LogData.IP), "Parâmetro IP não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.LogData.MAC))
            throw new ArgumentNullException(nameof(signUp.LogData.MAC), "Parâmetro MAC não pode ser nulo!");
    }
    public static void Validate(SimpleSignupRequest signUp)
    {
        if(signUp == null)
            throw new ArgumentNullException(nameof(signUp), "Requisição não pode ser nula!");

        if(String.IsNullOrEmpty(signUp.CPF))
            throw new ArgumentNullException(nameof(signUp.CPF), "CPF não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.Name))
            throw new ArgumentNullException(nameof(signUp.Name), "Nome não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.Birthday))
            throw new ArgumentNullException(nameof(signUp.Birthday), "Data de nascimento não pode ser nula!");

        if(String.IsNullOrEmpty(signUp.Email))
            throw new ArgumentNullException(nameof(signUp.Email), "E-Mail não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.Phone))
            throw new ArgumentNullException(nameof(signUp.Phone), "Número de telefone não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.ZipCode))
            throw new ArgumentNullException(nameof(signUp.ZipCode), "CEP não pode ser nulo!");

        if(signUp.LogData == null)
            throw new ArgumentNullException(nameof(signUp.LogData), "Instituição bancária não pode ser nula!");

        if(signUp.LogData.Latitude > 90 || signUp.LogData.Latitude < -90)
            throw new ArgumentNullException(nameof(signUp.LogData.Latitude), "Latitude fora do padrão!");

        if(signUp.LogData.Longitude > 180 || signUp.LogData.Longitude < -180)
            throw new ArgumentNullException(nameof(signUp.LogData), "Longitude fora do padrão!");

        if(String.IsNullOrEmpty(signUp.LogData.UserAgent))
            throw new ArgumentNullException(nameof(signUp.LogData.UserAgent), "Parâmetro UserAgent não pode ser nulo!");

        if(String.IsNullOrEmpty(signUp.LogData.IP))
            throw new ArgumentNullException(nameof(signUp.LogData.IP), "Parâmetro IP não pode ser nulo!");

        // if(String.IsNullOrEmpty(signUp.LogData.MAC))
        //     throw new ArgumentNullException(nameof(signUp.LogData.MAC), "Parâmetro MAC não pode ser nulo!");
    }
    public static void Validate(ProposalRequest proposal)
    {
        if(proposal == null)
            throw new ArgumentNullException(nameof(proposal), "Requisição não pode ser nula!");

        if(String.IsNullOrEmpty(proposal.Mother))
            throw new ArgumentNullException(nameof(proposal.Mother), "O nome da mãe não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Gender))
            throw new ArgumentNullException(nameof(proposal.Gender), "O genero não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Nationality))
            throw new ArgumentNullException(nameof(proposal.Nationality), "Nacionalidade não pode ser nula!");

        if(String.IsNullOrEmpty(proposal.HometownState))
            throw new ArgumentNullException(nameof(proposal.HometownState), "O estado não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Hometown))
            throw new ArgumentNullException(nameof(proposal.Hometown), "A cidade não pode ser nula!");

        if(String.IsNullOrEmpty(proposal.Education))
            throw new ArgumentNullException(nameof(proposal.Education), "A educação não pode ser nula!");

        if(String.IsNullOrEmpty(proposal.RelationshipStatus))
            throw new ArgumentNullException(nameof(proposal.RelationshipStatus), "O estado civil não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.PhoneLandLine))
            throw new ArgumentNullException(nameof(proposal.PhoneLandLine), "O Telefone fixo não pode ser nulo!");

        if(proposal.Identity == null)
            throw new ArgumentNullException(nameof(proposal.Identity), "Identity não pode ser nula!");

        if(String.IsNullOrEmpty(proposal.Identity.IdentityType))
            throw new ArgumentNullException(nameof(proposal.Identity.IdentityType), "O tipo de documento não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Identity.IdentityNumber))
            throw new ArgumentNullException(nameof(proposal.Identity.IdentityNumber), "O número do documento não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Identity.IdentityNumber))
            throw new ArgumentNullException(nameof(proposal.Identity.IdentityNumber), "O número do documento não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Identity.Issuer))
            throw new ArgumentNullException(nameof(proposal.Identity.Issuer), "O órgão emissor não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Identity.State))
            throw new ArgumentNullException(nameof(proposal.Identity.State), "O estado emissor não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Identity.IssuingDate))
            throw new ArgumentNullException(nameof(proposal.Identity.IssuingDate), "A data de emissão não pode ser nula!");

        if(proposal.Address == null)
            throw new ArgumentNullException(nameof(proposal.Address), "Address não pode ser nula!");

        if(String.IsNullOrEmpty(proposal.Address.ZipCode))
            throw new ArgumentNullException(nameof(proposal.Address.ZipCode), "CEP não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Address.Street))
            throw new ArgumentNullException(nameof(proposal.Address.Street), "Nome da rua não pode ser nulo!");

        if(proposal.Address.Number <= 0)
            throw new ArgumentNullException(nameof(proposal.Address.Number), "Número da residência inválido!");

        if(String.IsNullOrEmpty(proposal.Address.Complement))
            throw new ArgumentNullException(nameof(proposal.Address.Complement), "Complemento não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Address.District))
            throw new ArgumentNullException(nameof(proposal.Address.District), "Bairro/Distrito não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Address.State))
            throw new ArgumentNullException(nameof(proposal.Address.State), "Estado não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Address.City))
            throw new ArgumentNullException(nameof(proposal.Address.City), "Cidade não pode ser nula!");

        if(String.IsNullOrEmpty(proposal.Address.HomeType))
            throw new ArgumentNullException(nameof(proposal.Address.HomeType), "Tipo de residência não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Address.HomeSince))
            throw new ArgumentNullException(nameof(proposal.Address.HomeSince), "Tempo de moradia de residência não pode ser nulo!");

        if(proposal.Vehicle == null)
            throw new ArgumentNullException(nameof(proposal.Address), "Vehicle não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Vehicle.LicensePlate))
            throw new ArgumentNullException(nameof(proposal.Vehicle.LicensePlate), "A Placa do veículo não pode ser nula!");

        if(proposal.ConsumerUnit == null)
            throw new ArgumentNullException(nameof(proposal.ConsumerUnit), "ConsumerUnit não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.ConsumerUnit.Number))
            throw new ArgumentNullException(nameof(proposal.ConsumerUnit.Number), "Número da unidade de consumo não pode ser nulo!");

        if(proposal.ConsumerUnit == null)
            throw new ArgumentNullException(nameof(proposal.ConsumerUnit), "ConsumerUnit não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.ConsumerUnit.Number))
            throw new ArgumentNullException(nameof(proposal.ConsumerUnit.Number), "Número da unidade de consumo não pode ser nulo!");

        if(proposal.Business == null)
            throw new ArgumentNullException(nameof(proposal.Business), "Business não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Business.Occupation))
            throw new ArgumentNullException(nameof(proposal.Business.Occupation), "Ocupação não pode ser nula!");

        if(String.IsNullOrEmpty(proposal.Business.Profession))
            throw new ArgumentNullException(nameof(proposal.Business.Profession), "Profissão não pode ser nula!");

        if(String.IsNullOrEmpty(proposal.Business.CompanyName))
            throw new ArgumentNullException(nameof(proposal.Business.CompanyName), "Nome da Empresa não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Business.Phone))
            throw new ArgumentNullException(nameof(proposal.Business.Phone), "Telefone não pode ser nulo!");

        if(proposal.Business.Income < 0)
            throw new ArgumentNullException(nameof(proposal.Business.Income), "Salário não pode ser menor que zero!");

        if(proposal.Business.PayDay < 0 || proposal.Business.PayDay > 30)
            throw new ArgumentNullException(nameof(proposal.Business.PayDay), "Dia do pagamento não é válido!");

        if(String.IsNullOrEmpty(proposal.Business.BenefitNumber))
            throw new ArgumentNullException(nameof(proposal.Business.BenefitNumber), "Número do benefício não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Business.ZipCode))
            throw new ArgumentNullException(nameof(proposal.Business.ZipCode), "CEP não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Business.Street))
            throw new ArgumentNullException(nameof(proposal.Business.Street), "Nome da rua não pode ser nulo!");

        if(proposal.Business.Number <= 0)
            throw new ArgumentNullException(nameof(proposal.Business.Number), "Número da residência inválido!");

        if(String.IsNullOrEmpty(proposal.Business.Complement))
            throw new ArgumentNullException(nameof(proposal.Business.Complement), "Complemento não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Business.District))
            throw new ArgumentNullException(nameof(proposal.Business.District), "Bairro/Distrito não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Business.State))
            throw new ArgumentNullException(nameof(proposal.Business.State), "Estado não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Business.City))
            throw new ArgumentNullException(nameof(proposal.Business.City), "Cidade não pode ser nula!");

        if(proposal.Bank == null)
            throw new ArgumentNullException(nameof(proposal.Bank), "Bank não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Bank.Banks))
            throw new ArgumentNullException(nameof(proposal.Bank.Banks), "Número do banco não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Bank.Type))
            throw new ArgumentNullException(nameof(proposal.Bank.Type), "Tipo da conta não pode ser nulo!");

        if(String.IsNullOrEmpty(proposal.Bank.Agency))
            throw new ArgumentNullException(nameof(proposal.Bank.Agency), "Agência não pode ser nula!");

        if(String.IsNullOrEmpty(proposal.Bank.Account))
            throw new ArgumentNullException(nameof(proposal.Bank.Account), "Conta não pode ser nula!");

        if(proposal.Reference == null)
            throw new ArgumentNullException(nameof(proposal.Bank), "Lista de referências não pode ser nula!");

        if(proposal.Products == null)
            throw new ArgumentNullException(nameof(proposal.Bank), "Lista de produtos não pode ser nula!");
    }
    public static void Validate(SimpleProposalRequest simpleProposal)
    {
        if(simpleProposal == null)
            throw new ArgumentNullException(nameof(simpleProposal), "Requisição não pode ser nula!");

        if(String.IsNullOrEmpty(simpleProposal.Mother))
            throw new ArgumentNullException(nameof(simpleProposal.Mother), "O nome da mãe não pode ser nulo!");

        if(String.IsNullOrEmpty(simpleProposal.HometownState))
            throw new ArgumentNullException(nameof(simpleProposal.HometownState), "O estado não pode ser nulo!");

        if(String.IsNullOrEmpty(simpleProposal.RelationshipStatus))
            throw new ArgumentNullException(nameof(simpleProposal.RelationshipStatus), "O estado civil não pode ser nulo!");

        if(simpleProposal.Address == null)
            throw new ArgumentNullException(nameof(simpleProposal.Address), "Address não pode ser nula!");

        if(String.IsNullOrEmpty(simpleProposal.Address.ZipCode))
            throw new ArgumentNullException(nameof(simpleProposal.Address.ZipCode), "CEP não pode ser nulo!");

        if(String.IsNullOrEmpty(simpleProposal.Address.Street))
            throw new ArgumentNullException(nameof(simpleProposal.Address.Street), "Nome da rua não pode ser nulo!");

        if(simpleProposal.Address.Number <= 0)
            throw new ArgumentNullException(nameof(simpleProposal.Address.Number), "Número da residência inválido!");

        if(String.IsNullOrEmpty(simpleProposal.Address.Complement))
            throw new ArgumentNullException(nameof(simpleProposal.Address.Complement), "Complemento não pode ser nulo!");

        if(String.IsNullOrEmpty(simpleProposal.Address.District))
            throw new ArgumentNullException(nameof(simpleProposal.Address.District), "Bairro/Distrito não pode ser nulo!");

        if(String.IsNullOrEmpty(simpleProposal.Address.State))
            throw new ArgumentNullException(nameof(simpleProposal.Address.State), "Estado não pode ser nulo!");

        if(String.IsNullOrEmpty(simpleProposal.Address.City))
            throw new ArgumentNullException(nameof(simpleProposal.Address.City), "Cidade não pode ser nula!");

        if(String.IsNullOrEmpty(simpleProposal.Address.HomeType))
            throw new ArgumentNullException(nameof(simpleProposal.Address.HomeType), "Tipo de residência não pode ser nulo!");

        if(String.IsNullOrEmpty(simpleProposal.Address.HomeSince))
            throw new ArgumentNullException(nameof(simpleProposal.Address.HomeSince), "Tempo de moradia de residência não pode ser nulo!");

        if(simpleProposal.BusinessIncome == null)
            throw new ArgumentNullException(nameof(simpleProposal.Address), "Ganho mensal não pode ser nulo!");

        if(simpleProposal.BusinessIncome.Income <= 0)
            throw new ArgumentNullException(nameof(simpleProposal.BusinessIncome.Income), "Ganho mensal não pode ser nulo!");

        if(simpleProposal.Products == null)
            throw new ArgumentNullException(nameof(simpleProposal.Products), "Lista de produtos não pode ser nula!");
    }
    public static void Validate(DocumentRequest document)
    {
        if(document == null)
            throw new ArgumentNullException(nameof(document), "document não pode ser nulo!");

        if(String.IsNullOrEmpty(document.Name))
            throw new ArgumentNullException(nameof(document.Name), "O nome do documento não pode ser nulo!");

        if(String.IsNullOrEmpty(document.Type))
            throw new ArgumentNullException(nameof(document.Type), "O tipo do documento não pode ser nulo!");

        if(String.IsNullOrEmpty(document.MimeType))
            throw new ArgumentNullException(nameof(document.MimeType), "A extenção do documento não pode ser nulo!");

        if(String.IsNullOrEmpty(document.Base64))
            throw new ArgumentNullException(nameof(document.Base64), "O código 64 do documento não pode ser nulo!");
    }
    public static void Validate(SignContractRequest contract)
    {
        if(contract == null)
            throw new ArgumentNullException(nameof(contract), "contract não pode ser nulo!");

        if(contract.AceptedCheckSum == null)
            throw new ArgumentNullException(nameof(contract.AceptedCheckSum), "AceptedCheckSum não pode ser nulo!");

        if(contract.LogData == null)
            throw new ArgumentNullException(nameof(contract.LogData), "Instituição bancária não pode ser nula!");

        if(contract.LogData.Latitude > 90 || contract.LogData.Latitude < -90)
            throw new ArgumentNullException(nameof(contract.LogData.Latitude), "Latitude fora do padrão!");

        if(contract.LogData.Longitude > 180 || contract.LogData.Longitude < -180)
            throw new ArgumentNullException(nameof(contract.LogData), "Longitude fora do padrão!");

        if(String.IsNullOrEmpty(contract.LogData.UserAgent))
            throw new ArgumentNullException(nameof(contract.LogData.UserAgent), "Parâmetro UserAgent não pode ser nulo!");

        if(String.IsNullOrEmpty(contract.LogData.IP))
            throw new ArgumentNullException(nameof(contract.LogData.IP), "Parâmetro IP não pode ser nulo!");

        if(String.IsNullOrEmpty(contract.LogData.MAC))
            throw new ArgumentNullException(nameof(contract.LogData.MAC), "Parâmetro MAC não pode ser nulo!");
    }
    public static void Validade(PubSubResponse pubSubResponse)
    {
        if(pubSubResponse == null)
            throw new ArgumentNullException(nameof(pubSubResponse), "pubSubResponse não pode ser nulo!");

        if(String.IsNullOrEmpty(pubSubResponse.ProjectId))
            throw new ArgumentNullException(nameof(pubSubResponse.ProjectId), "ProjectId não pode ser nulo!");

        if(String.IsNullOrEmpty(pubSubResponse.ServiceAccount))
            throw new ArgumentNullException(nameof(pubSubResponse.ServiceAccount), "ServiceAccount não pode ser nulo!");

        if(String.IsNullOrEmpty(pubSubResponse.SubscriptionId))
            throw new ArgumentNullException(nameof(pubSubResponse.SubscriptionId), "SubscriptionId não pode ser nulo!");

        if(String.IsNullOrEmpty(pubSubResponse.TopicId))
            throw new ArgumentNullException(nameof(pubSubResponse.TopicId), "TopicId não pode ser nulo!");
    }
}

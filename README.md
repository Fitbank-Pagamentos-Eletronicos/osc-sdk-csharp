# Getting Started

Welcome to the OSC SDK C# project.

## Description

This documentation is made to help developers better understand its structures and methods, here you will have a deep dive into each method thoroughly with a simple yet complete explanation. For any problems, questions and/or issues, please create a new issue on the issues tab and the team will try to respond it as soon as possible.

## Folder Structure

The workspace contains three main folders, where:

- `./Requests`: This is the Integration layer, here you will find all the requests to external APIs;
- `./Utils`: This is the support layer, here you will find the methods that are used to help and/or clean the overall code from the SDK;
- `./src`: This is the Enumeration and Domain layer, here you will find the Objects and Enums that the SDK utilizes throughout its code structure;

for the subfolders, it is divided into the following structure:

- `./src/Enums`: This is where all the Enums and Dictionaries are located;
- `./src/Models`: This is where all the Domains and Objects are located; (currently being refactored)
- `./src/Models/Responses`: This is where the Objects that are used to map requisition responses are located;
- `.src/Models/Requests`: This is where the Objects that are used to map requisition requests are located;
- `.src/Models/SubDomains`: This is where the Objects that are used to build other Objects are located;
<details>
  <summary><h4>Complete folder structure:</h4></summary>
  
```
📦osc-sdk-csharp
 ┣ 📂osc-sdk-csharp
 ┃ ┣ 📂bin
 ┃ ┃ ┗ 📂Debug
 ┃ ┃ ┃ ┗ 📂net6.0
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.deps.json
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.dll
 ┃ ┃ ┃ ┃ ┗ 📜osc-sdk-csharp.pdb
 ┃ ┣ 📂obj
 ┃ ┃ ┣ 📂Debug
 ┃ ┃ ┃ ┗ 📂net6.0
 ┃ ┃ ┃ ┃ ┣ 📂ref
 ┃ ┃ ┃ ┃ ┃ ┗ 📜osc-sdk-csharp.dll
 ┃ ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┃ ┗ 📜osc-sdk-csharp.dll
 ┃ ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v6.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.assets.cache
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.csproj.BuildWithSkipAnalyzers
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.dll
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┣ 📜osc-sdk-csharp.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┗ 📜osc-sdk-csharp.pdb
 ┃ ┃ ┣ 📜osc-sdk-csharp.csproj.nuget.dgspec.json
 ┃ ┃ ┣ 📜osc-sdk-csharp.csproj.nuget.g.props
 ┃ ┃ ┣ 📜osc-sdk-csharp.csproj.nuget.g.targets
 ┃ ┃ ┣ 📜project.assets.json
 ┃ ┃ ┗ 📜project.nuget.cache
 ┃ ┣ 📂Requests
 ┃ ┃ ┣ 📜OAuth.cs
 ┃ ┃ ┣ 📜OContract.cs
 ┃ ┃ ┣ 📜ODocument.cs
 ┃ ┃ ┣ 📜OProposal.cs
 ┃ ┃ ┣ 📜OPubSub.cs
 ┃ ┃ ┗ 📜OSignUp.cs
 ┃ ┣ 📂src
 ┃ ┃ ┣ 📂Enums
 ┃ ┃ ┃ ┣ 📜AccountType.cs
 ┃ ┃ ┃ ┣ 📜Banks.cs
 ┃ ┃ ┃ ┣ 📜CreditCardBenefits.cs
 ┃ ┃ ┃ ┣ 📜CreditStatus.cs
 ┃ ┃ ┃ ┣ 📜DocumentType.cs
 ┃ ┃ ┃ ┣ 📜Education.cs
 ┃ ┃ ┃ ┣ 📜EmploymentSince.cs
 ┃ ┃ ┃ ┣ 📜Gender.cs
 ┃ ┃ ┃ ┣ 📜HomeSince.cs
 ┃ ┃ ┃ ┣ 📜HomeType.cs
 ┃ ┃ ┃ ┣ 📜IdentityIssuer.cs
 ┃ ┃ ┃ ┣ 📜IdentityType.cs
 ┃ ┃ ┃ ┣ 📜LoanObjectives.cs
 ┃ ┃ ┃ ┣ 📜MimeType.cs
 ┃ ┃ ┃ ┣ 📜Nationality.cs
 ┃ ┃ ┃ ┣ 📜Network.cs
 ┃ ┃ ┃ ┣ 📜Occupation.cs
 ┃ ┃ ┃ ┣ 📜PendentDocuments.cs
 ┃ ┃ ┃ ┣ 📜ProductType.cs
 ┃ ┃ ┃ ┣ 📜RealEstateType.cs
 ┃ ┃ ┃ ┣ 📜RelationshipStatus.cs
 ┃ ┃ ┃ ┣ 📜Scopes.cs
 ┃ ┃ ┃ ┣ 📜State.cs
 ┃ ┃ ┃ ┗ 📜URLSettings.cs
 ┃ ┃ ┗ 📂Models
 ┃ ┃ ┃ ┣ 📂Requests
 ┃ ┃ ┃ ┃ ┣ 📜AuthRequest.cs
 ┃ ┃ ┃ ┃ ┣ 📜DocumentRequest.cs
 ┃ ┃ ┃ ┃ ┣ 📜ProposalRequest.cs
 ┃ ┃ ┃ ┃ ┣ 📜SignContractRequest.cs
 ┃ ┃ ┃ ┃ ┣ 📜SignupRequest.cs
 ┃ ┃ ┃ ┃ ┣ 📜SimpleProposalRequest.cs
 ┃ ┃ ┃ ┃ ┗ 📜SimpleSignupRequest.cs
 ┃ ┃ ┃ ┣ 📂Responses
 ┃ ┃ ┃ ┃ ┣ 📜AuthResponse.cs
 ┃ ┃ ┃ ┃ ┣ 📜DocumentResponse.cs
 ┃ ┃ ┃ ┃ ┣ 📜GetContractResponse.cs
 ┃ ┃ ┃ ┃ ┣ 📜Pipeline.cs
 ┃ ┃ ┃ ┃ ┣ 📜PubSubResponse.cs
 ┃ ┃ ┃ ┃ ┣ 📜SignContractResponse.cs
 ┃ ┃ ┃ ┃ ┗ 📜SignUpResponse.cs
 ┃ ┃ ┃ ┗ 📂SubDomains
 ┃ ┃ ┃ ┃ ┣ 📜Address.cs
 ┃ ┃ ┃ ┃ ┣ 📜Auto.cs
 ┃ ┃ ┃ ┃ ┣ 📜Bank.cs
 ┃ ┃ ┃ ┃ ┣ 📜BankAccount.cs
 ┃ ┃ ┃ ┃ ┣ 📜BorrowerInfo.cs
 ┃ ┃ ┃ ┃ ┣ 📜Business.cs
 ┃ ┃ ┃ ┃ ┣ 📜BusinessIncome.cs
 ┃ ┃ ┃ ┃ ┣ 📜Card.cs
 ┃ ┃ ┃ ┃ ┣ 📜ConsumerUnit.cs
 ┃ ┃ ┃ ┃ ┣ 📜ContractBody.cs
 ┃ ┃ ┃ ┃ ┣ 📜Credit.cs
 ┃ ┃ ┃ ┃ ┣ 📜Error.cs
 ┃ ┃ ┃ ┃ ┣ 📜ErrorField.cs
 ┃ ┃ ┃ ┃ ┣ 📜ErrorFields.cs
 ┃ ┃ ┃ ┃ ┣ 📜Home.cs
 ┃ ┃ ┃ ┃ ┣ 📜Identity.cs
 ┃ ┃ ┃ ┃ ┣ 📜Loan.cs
 ┃ ┃ ┃ ┃ ┣ 📜LogData.cs
 ┃ ┃ ┃ ┃ ┣ 📜Match.cs
 ┃ ┃ ┃ ┃ ┣ 📜MatchAuto.cs
 ┃ ┃ ┃ ┃ ┣ 📜MatchCard.cs
 ┃ ┃ ┃ ┃ ┣ 📜MatchHome.cs
 ┃ ┃ ┃ ┃ ┣ 📜MatchLoan.cs
 ┃ ┃ ┃ ┃ ┣ 📜PipelineMatchLoan.cs
 ┃ ┃ ┃ ┃ ┣ 📜PipelineWithBankAccountProposal.cs
 ┃ ┃ ┃ ┃ ┣ 📜PipelineWithProposal.cs
 ┃ ┃ ┃ ┃ ┣ 📜Product.cs
 ┃ ┃ ┃ ┃ ┣ 📜ProductAuto.cs
 ┃ ┃ ┃ ┃ ┣ 📜ProductBankAccount.cs
 ┃ ┃ ┃ ┃ ┣ 📜ProductCard.cs
 ┃ ┃ ┃ ┃ ┣ 📜ProductHome.cs
 ┃ ┃ ┃ ┃ ┣ 📜ProductLoan.cs
 ┃ ┃ ┃ ┃ ┣ 📜Products.cs
 ┃ ┃ ┃ ┃ ┣ 📜Proposals.cs
 ┃ ┃ ┃ ┃ ┣ 📜Reference.cs
 ┃ ┃ ┃ ┃ ┣ 📜ServiceAccount.cs
 ┃ ┃ ┃ ┃ ┣ 📜Vehicle.cs
 ┃ ┃ ┃ ┃ ┗ 📜VehicleInformation.cs
 ┃ ┣ 📂Utils
 ┃ ┃ ┗ 📜Validator.cs
 ┃ ┣ 📜osc-sdk-csharp.csproj
 ┃ ┗ 📜Osc.cs
 ┣ 📂tests
 ┃ ┣ 📂bin
 ┃ ┃ ┗ 📂Debug
 ┃ ┃ ┃ ┗ 📂net6.0
 ┃ ┃ ┃ ┃ ┗ 📜CoverletSourceRootsMapping
 ┃ ┣ 📂obj
 ┃ ┃ ┣ 📂Debug
 ┃ ┃ ┃ ┗ 📂net6.0
 ┃ ┃ ┃ ┃ ┣ 📂ref
 ┃ ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v6.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┣ 📜tests.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┣ 📜tests.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┣ 📜tests.assets.cache
 ┃ ┃ ┃ ┃ ┣ 📜tests.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┃ ┣ 📜tests.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┗ 📜tests.GlobalUsings.g.cs
 ┃ ┃ ┣ 📜project.assets.json
 ┃ ┃ ┣ 📜project.nuget.cache
 ┃ ┃ ┣ 📜tests.csproj.nuget.dgspec.json
 ┃ ┃ ┣ 📜tests.csproj.nuget.g.props
 ┃ ┃ ┗ 📜tests.csproj.nuget.g.targets
 ┃ ┣ 📜OSCTests.cs
 ┃ ┣ 📜tests.csproj
 ┃ ┗ 📜Usings.cs
 ┣ 📜.gitattributes
 ┣ 📜.gitignore
 ┣ 📜osc-sdk-csharp.sln
 ┗ 📜README.md
```
</details>

## How to test the project:

To test this project, first a separate project will have to be created, since <b>.NET</b> does not support Class Libs to run independently. The following examples will show how to test it on a Console project:
<b>
<details>
<summary><h3>AUTH</h3></summary>

To test the Auth method, you will need to implement the following command:

```C#
namespace TestConsole;
internal class Class1
{
    public static void Main( )
    {
        Console.WriteLine(
            OSC.Auth( )
            );
    }
}
```

this will retrieve a response containing the token and expiration date as in the image below:

![Auth_Test_Result](https://user-images.githubusercontent.com/97535617/209838736-31a03b94-d711-467b-a90f-46dfb86d66ff.jpg)

this response will allow you to have access to all of the other methods, as it automatically saves the token and expiration date to the code itself, also as long as the first auth is made, the code will automatically refresh and generate you a new token as soon as the previous one expires. <br>
<b>(Note: the token will not refresh if you stop compiling the project, since it uses RAM based data storage)</b>
</details>
<details>
<summary><h3>CREATE & GET INSTANCE</h3></summary>

To test the CreateInstance and GetInstance methods, you will need to implement the following commands:
```C#
namespace TestConsole;
internal class Class1
{
    public static void Main( )
    {
        OSC.CreateInstance( );

        Console.WriteLine(
            OSC.GetInstance( )
            );
    }
}
```
this will create a instance and return that same instance as in the image below:

![Instance_Test_Result](https://user-images.githubusercontent.com/97535617/209853688-2b4c7b4b-e22e-4d33-8470-e912146f351d.jpg)

this will allow the User to have one or multiple instances, making possible the management of credentials and/or blocking certain methods to certain users.
</details>
<details>
<summary><h3>GET TOKEN</h3></summary>

To test the GetToken method, you will need to implement the following command:
```C#
namespace TestConsole;
internal class Class1
{
    public static void Main( )
    {
        Console.WriteLine(
            OSC.GetToken( ) 
            );
    }
```
this will return your Auth token or generate a new token in case your current token has expired as in the image below:

![GetToken_Test_Result](https://user-images.githubusercontent.com/97535617/209946606-d5d5497c-48d9-4ad0-af75-e3b2df036be0.jpg)

this will allow the User to get their current token and expiration date at any moment, also it will refresh their token if the current one has expired.
</details>
<details>
<summary><h3>NORMALIZE</h3></summary>

To test the Normalize method, you will need to implement the following command:
```C#
namespace TestConsole;
internal class Class1
{
    public static void Main( )
    {
        Console.WriteLine(
            OSC.Normalize( )
            );
    }
}
```
this will return you the string given to the method without the uppercase letters and without special simbols as in the image below:

![Normalize_Test_Result](https://user-images.githubusercontent.com/97535617/209948638-ae8e1615-b8fe-4e61-9c61-b8c40bebc5fc.jpg)

this will allow the User to clean strings for various uses in the code.
</details>
<details>
<summary><h3>SIGNUP & SIMPLE SIGNUP</h3></summary>

To test the SignUp method, you will need to implement the following command:
```C#
namespace TestConsole;
internal class Class1
{
    public static void Main( )
    {
        OSC.Auth( );
        
        OSC.CreateInstance( );
        
        List<Products> products = new List<Products>( );

        SignupMatch signUp = new SignupMatch( );

        Console.WriteLine(
            OSC.SignUp( signUp )
            );
    }
}
```
this will return you the information of the User's credit sign up as in the image below:

![SignUp_Test_Result](https://user-images.githubusercontent.com/97535617/209952497-c354673e-50d5-4478-b0a8-36d58b0f86f4.jpg)

this will allow the User to have access to the Credit features given by the Easy Crédito API.
  
----
To test the SimpleSignUp method, you will need to implement the following command:
```C#
namespace TestConsole;
internal class Class1
{
    public static void Main( )
    {
        OSC.Auth( );
        
        OSC.CreateInstance( );
        
        SimpleSignup signUp = new SimpleSignup( );

        Console.WriteLine(
            OSC.SimpleSignUp( signUp )
            );
    }
}
```
this will return you the information of the User's credit sign up as in the image below:

![SimpleSignUp_Test_Result](https://user-images.githubusercontent.com/97535617/209952497-c354673e-50d5-4478-b0a8-36d58b0f86f4.jpg)

this will allow the User to have access to the Credit features given by the Easy Crédito API.
</details>
  
---
<h3>SIGNUP & SIMPLE SIGNUP FLOWCHART:</h3>
  
```mermaid
sequenceDiagram
    participant Client
    participant SDK
    participant Auth
    participant API

    Client->>+SDK: OSC.CreateInstance("Name")
    SDK-->>-Client: instance osc
    
    Client->>+SDK: OSC.SignUp(SignupMatch)
        opt Unauthorized 
            SDK->>+Auth: auth(client_id, client_secret, scope)
            Auth-->>-SDK: access_token
        end
        SDK->>+API: signup(SignupMatch)
        API-->>-SDK: pipelineJson
    SDK-->>-Client: pipeline instance
```

---
<details>
<summary><h3>DOCUMENT</h3></summary>

To test the Document method, you will need to implement the following command:
```C#
namespace TestConsole;
internal class Class1
{
    public static void Main( )
    {
        OSC.Auth( );

        SimpleSignup signUp = new SimpleSignup( );

        var jsonResponse = OSC.SimpleSignUp( signUp );
        SignUpResponse response = JsonConvert.DeserializeObject<SignUpResponse>( jsonResponse )!;

        Document document = new Document( );

        Thread.Sleep(10 * 1000);

        Console.WriteLine(
            OSC.Document(
                document, 
                response.ID
                )
            );
    }
}
```
this will return your document url as in the image below:

![Document_Test_Result](https://user-images.githubusercontent.com/97535617/209984465-8ecfa261-d93c-41ab-879c-63f1ac3ed55b.jpg)

this will allow the User to upload the required documents to the API and save them on the Easy Crédito server.
</details>
<details>
<summary><h3>PROPOSAL & SIMPLE PROPOSAL</h3></summary>

To test the Proposal method, you will need to implement the following command:
```C#
namespace TestConsole;
internal class Class1
{
    public static void Main( )
    {
        OSC.Auth( );

        SimpleSignup signUp = new SimpleSignup( );

        var jsonResponse = OSC.SimpleSignUp(signUp);
        SignUpResponse response = JsonConvert.DeserializeObject<SignUpResponse>(jsonResponse)!;

        Proposal proposal = new Proposal( );

        Thread.Sleep(10 * 1000);

        Console.WriteLine(
            OSC.Proposal(
                proposal, 
                response.ID
                )
            );
    }
}
```
this will return your proposal status as in the image below:

![Proposal_Test_Result](https://user-images.githubusercontent.com/97535617/209990348-89483873-2420-46b3-82c4-16d418bcaf4e.jpg)

this will allow the User to send requests for credit proposals to the Easy Crédito API.
  
---
To test the SimpleProposal method, you will need to implement the following command:
```C#
namespace TestConsole;
internal class Class1
{
    public static void Main( )
    {
        OSC.Auth( );

        SimpleSignup signUp = new SimpleSignup( );

        var jsonResponse = OSC.SimpleSignUp(signUp);
        SignUpResponse response = JsonConvert.DeserializeObject<SignUpResponse>(jsonResponse)!;

        ProposalBankAccount simpleProposal = new ProposalBankAccount( );

        Thread.Sleep(10 * 1000);

        Console.WriteLine(
            OSC.Proposal(
                proposal, 
                response.ID
                )
            );
    }
}
```
this will return your proposal status as in the image below:
(Note: In the code above, the object "signUp" can be either SimpleSignup or SignupMatch)

![SimpleProposal_Test_Result](https://user-images.githubusercontent.com/97535617/209990348-89483873-2420-46b3-82c4-16d418bcaf4e.jpg)

this will allow the User to send requests for credit proposals to the Easy Crédito API.
</details>
  
---
<h3>SIGNUP + PROPOSAL FLOWCHART:</h3>
  
```mermaid
sequenceDiagram
    participant Client
    participant SDK
    participant Auth
    participant API
    participant PubSub

 

    Client->>+SDK: OSC.createInstance(client_id, client_secret)
    SDK-->>-Client: instancia osc

    Client->>+SDK: osc.setResponseListening(listeningFunction)
        opt Não autorizado 
            SDK->>+Auth: auth(client_id, client_secret, scope)
            Auth-->>-SDK: access_token
        end
        SDK->>+API: pubsub(access_token)
        API-->>-SDK: pubsubConfig
        par Abre socket
            SDK->>PubSub: subscription(pubsubConfig)
        end
    SDK-->>-Client: pipeline instance

    Client->>+SDK: osc.signup(signupObject)
        opt Não autorizado 
            SDK->>+Auth: auth(client_id, client_secret, scope)
            Auth-->>-SDK: access_token
        end
        SDK->>+API: signup(signupJson, access_token)
        API-->>-SDK: pipelineJson
    SDK-->>-Client: pipeline instance
    API->>PubSub: publica(signupResponse)
    PubSub-->>SDK: subscriptionSocket(signupResponse)
    SDK-->>Client: listeningFunction(signupResponse)

    Client->>+SDK: osc.proposal(pipeline_id, proposalObject)
        opt Não autorizado 
            SDK->>+Auth: auth(client_id, client_secret, scope)
            Auth-->>-SDK: access_token
        end
        SDK->>+API: proposal(pipeline_id, proposalJson, access_token)
        API-->>-SDK: pipelineJson
    SDK-->>-Client: pipeline instance

    API->>PubSub: publica(proposalResponse)
    PubSub-->>SDK: subscriptionSocket(proposalResponse)
    SDK-->>Client: listeningFunction(proposalResponse)

    par Continuara recevbendo atualização de status durante o fluxo
        API->>PubSub: publica(proposalStatusUpdateResponse)
        PubSub-->>SDK: subscriptionSocket(proposalResponse)
        SDK-->>Client: listeningFunction(proposalResponse)
    and Nesta etapa o envio de documentos esta liberado
        Client->>+SDK: osc.document(pipeline_id, documentObject)
            opt Não autorizado 
                SDK->>+Auth: auth(client_id, client_secret, scope)
                Auth-->>-SDK: access_token
            end
            SDK->>+API: proposal(pipeline_id, documentJson, access_token)
            API-->>-SDK: documentResponseJson
        SDK-->>-Client: documentResponse instance
    and Caso alguma proposta retorne que tem contratos para asinatura
        Client->>+SDK: osc.getContracts(customerServiceNumber)
            opt Não autorizado 
                SDK->>+Auth: auth(client_id, client_secret, scope)
                Auth-->>-SDK: access_token
            end
            SDK->>+API: getContracts(customerServiceNumber, access_token)
            API-->>-SDK: contractsResponseJson
        SDK-->>-Client: contractsResponse instance

        Client->>+SDK: osc.SignContracts(customerServiceNumber, contractsObject)
            opt Não autorizado 
                SDK->>+Auth: auth(client_id, client_secret, scope)
                Auth-->>-SDK: access_token
            end
            SDK->>+API: SignContracts(customerServiceNumber, contractsObject, access_token)
            API-->>-SDK: signContractsResponseJson
        SDK-->>-Client: signContractsResponse instance
    end
```

  ---
<details>
<summary><h3>PUB/SUB</h3></summary>

To test the GetPubSub method, you will need to implement the following command:
```C#
namespace TestConsole;
internal class Class1
{
    public static void Main( )
    {
        OSC.Auth( );

        Console.WriteLine(OSC.GetPubSub( ));
    }
}
```
this will return your Pub/Sub message
(note: Due to hardships in testing of the Pub/Sub, there is no images to show the results of testing)

this will allow the User to get the callbacks from the Google server.
  
---
To test the PostPubSub method, you will need to implement the following command:
```C#
namespace TestConsole;
internal class Class1
{
    [Obsolete]
    public static void Main( )
    {
        OSC.Auth( );

        PubSubResponse response = JsonConvert.DeserializeObject<PubSubResponse>(OSC.GetPubSub( ))!;

        Console.WriteLine(OSC.PostPubSub(response));
    }
}
```
this will send your message to the cloud
(note: Due to hardships in testing of the Pub/Sub, there is no images to show the results of testing)

this will allow the User to send callbacks to the Google server.
</details>
</b>

## References

1. https://developers.easycredito.com.br/
2. https://www.newtonsoft.com/json/help/html/Introduction.htm
3. https://cloud.google.com/pubsub/docs
4. https://learn.microsoft.com/en-us/dotnet/csharp/
5. https://learn.microsoft.com/en-us/dotnet/fundamentals/

## Other Projects:

1. https://github.com/Fitbank-Pagamentos-Eletronicos/osc-sdk-python
2. https://github.com/Fitbank-Pagamentos-Eletronicos/osc-sdk-nodejs
3. https://github.com/Fitbank-Pagamentos-Eletronicos/osc-sdk-go
4. https://github.com/Fitbank-Pagamentos-Eletronicos/osc-sdk-java

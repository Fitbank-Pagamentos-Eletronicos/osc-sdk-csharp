namespace osc_sdk_csharp.src.Models.SubDomains;
public record Proposals
{
    public Loan? Loan { get; set; }
    public Card? Card { get; set; }
    public Auto? Auto { get; set; }
    public Home? Home { get; set; }

    public Proposals(Loan? loan, Card? card, Auto? auto, Home? home)
    {
        Loan = loan;
        Card = card;
        Auto = auto;
        Home = home;
    }
}
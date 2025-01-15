namespace FactoryMethod;

public class InterstateBusCompany : Company
{
    public override Ticket IssueTicket(string departure, string destination)
    {
        return new InterstateBusTicket(departure, destination);
    }
}
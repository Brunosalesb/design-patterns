namespace FactoryMethod;

public class UrbanBusCompany : Company
{
    public override Ticket IssueTicket(string departure, string destination)
    {
        return new UrbanBusTicket(departure, destination);
    }
}
namespace FactoryMethod;

public abstract class Company
{
    public abstract Ticket IssueTicket(string departure, string destination);
}
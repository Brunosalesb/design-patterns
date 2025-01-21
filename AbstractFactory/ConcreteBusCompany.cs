namespace AbstractFactory;

public class ConcreteBusCompany : BusCompany
{
    public override UrbanBusTicket IssueUrbanBusTicket(string departure, string destination)
    {
        return new ConcreteUrbanBusTicket(departure, destination);
    }

    public override InterstateBusTicket IssueInterstateBusTicket(string departure, string destination)
    {
        return new ConcreteInterstateBusTicket(departure, destination);
    }
}
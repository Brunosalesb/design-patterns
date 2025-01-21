namespace AbstractFactory;

public abstract class BusCompany
{
    public abstract UrbanBusTicket IssueUrbanBusTicket(string departure, string destination);
	
    public abstract InterstateBusTicket IssueInterstateBusTicket(string departure, string destination);
}
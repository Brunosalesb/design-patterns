namespace AbstractFactory;

public abstract class InterstateBusTicket
{
    public string Departure;
    public string Destination;
    
    public InterstateBusTicket(string departure, string destination)
    {
        Departure = departure;
        Destination = destination;
    }
    
    public abstract void ShowDetails();
}
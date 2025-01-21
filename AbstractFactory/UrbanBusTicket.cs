namespace AbstractFactory;

public abstract class UrbanBusTicket
{
    public string Departure;
    public string Destination;
    
    public UrbanBusTicket(string departure, string destination)
    {
        Departure = departure;
        Destination = destination;
    }
    
    public abstract void ShowDetails();
}
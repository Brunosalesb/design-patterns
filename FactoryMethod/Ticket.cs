namespace FactoryMethod;

public abstract class Ticket
{
    public string Departure;
    public string Destination;

    public Ticket(string departure, string destination)
    {
        Departure = departure;
        Destination = destination;
    }
    
    public abstract void ShowDetails();
}
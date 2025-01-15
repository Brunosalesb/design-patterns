namespace FactoryMethod;

public class UrbanBusTicket : Ticket
{
    public UrbanBusTicket(string departure, string destination) : base(departure, destination)
    {
    }
    
    public override void ShowDetails()
    {
        Console.WriteLine($"Urban bus ticket: {Departure} to {Destination}.");
    }
}
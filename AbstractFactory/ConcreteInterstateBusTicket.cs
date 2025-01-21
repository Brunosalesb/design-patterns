namespace AbstractFactory;

public class ConcreteInterstateBusTicket : InterstateBusTicket
{
    public ConcreteInterstateBusTicket(string departure, string destination) : base(departure, destination)
    {
        
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Interstate Bus Ticket: {Departure} to {Destination}");
    }
}
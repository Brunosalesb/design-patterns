namespace AbstractFactory;

public class ConcreteUrbanBusTicket : UrbanBusTicket
{
    public ConcreteUrbanBusTicket(string departure, string destination) : base(departure, destination)
    {
        
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Urban Bus Ticket: {Departure} to {Destination}");
    }
}
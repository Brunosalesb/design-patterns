namespace FactoryMethod;

public class InterstateBusTicket : Ticket
{
    public InterstateBusTicket(string departure, string destination) : base(departure, destination)
    {
    }


    public override void ShowDetails()
    {
        Console.WriteLine($"Interstate bus ticket: {Departure} to {Destination}.");
    }
}
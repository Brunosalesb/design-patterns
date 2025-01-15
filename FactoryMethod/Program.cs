using FactoryMethod;

var urbanBus = new UrbanBusCompany();
var interstateBus = new InterstateBusCompany();

var urbanTicket = urbanBus.IssueTicket("Piccadilly Circus","Camden Town");
var interstateTicket = interstateBus.IssueTicket("Los Angeles, CA","Las Vegas, NV");

urbanTicket.ShowDetails();
interstateTicket.ShowDetails();


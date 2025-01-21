using FactoryMethod;

UrbanBusCompany urbanBusCompany = new UrbanBusCompany();
InterstateBusCompany interstateBusCompany = new InterstateBusCompany();

Ticket urbanTicket = urbanBusCompany.IssueTicket("Piccadilly Circus","Camden Town");
Ticket interstateTicket = interstateBusCompany.IssueTicket("Los Angeles, CA","Las Vegas, NV");

urbanTicket.ShowDetails();
interstateTicket.ShowDetails();
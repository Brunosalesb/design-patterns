using AbstractFactory;

BusCompany busCompany = new ConcreteBusCompany();
UrbanBusTicket urbanTicket = busCompany.IssueUrbanBusTicket("Piccadilly Circus","Camden Town");
InterstateBusTicket interstateTicket = busCompany.IssueInterstateBusTicket("Los Angeles, CA","Las Vegas, NV");
		
urbanTicket.ShowDetails();
interstateTicket.ShowDetails();
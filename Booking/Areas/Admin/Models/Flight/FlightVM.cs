namespace Booking.Areas.Admin.Models.Flight
{
    public class FlightVM
    {
        public string Airplane { get; set; } = null!;
        public string Airline { get; set; } = null!;
        public string Departure { get; set; } = null!;
        public string Arrival { get; set; } = null!;
        public Decimal Price { get; set; }
        public string DepartureTime { get; set; } = null!;
        public string ArrivalTime { get; set; } = null!;
        public string FlightNumber { get; set; } = null!;
        public string FlightLogo { get; set; } = null!;
    }

    public class FlightInfo
    {
        public List<FlightVM> OutboundFlight { get; set; } = new List<FlightVM>();
        public List<FlightVM> ReturnFlight { get; set; } = new List<FlightVM>();
    }
}

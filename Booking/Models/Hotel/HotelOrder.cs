namespace Booking.Models.Hotel
{
    public class HotelOrder : Order
    {
        public string CheckInDate { get; set; } = null!;
        public string CheckOutDate { get; set; } = null!;
        public int NumberRoom { get; set; }
    }
}

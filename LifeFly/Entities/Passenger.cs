namespace LifeFly.Entities
{
    public class Passenger
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string PassengerType { get; set; }
        public string SeatNumber { get; internal set; }
        public string TicketStatus { get; internal set; }
        public string PaymentStatus { get; internal set; }
        public string CheckInStatus { get; internal set; }
    }
}

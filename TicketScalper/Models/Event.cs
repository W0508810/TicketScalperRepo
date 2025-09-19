namespace TicketScalper.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int TicketPrice { get; set; }
        public int CategoryId { get; set; } //foreign key
        public int VenueId { get; set; } // foreign key

        public List<Ticket>? Tickets { get; set; } //navigation property










    }
}

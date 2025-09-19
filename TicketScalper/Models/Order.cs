namespace TicketScalper.Models
{
    public class Order
    {
        public int OrderId { get; set; } // Primary key
        public int TicketId { get; set; }  //foreign key from Ticket
        public int UserId { get; set; } // foreign key from User
        public int VenueId { get; set; } //foreign key from Venue
        public DateTime OrderDate { get; set; }

       



    }
}

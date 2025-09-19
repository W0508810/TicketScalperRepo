namespace TicketScalper.Models
{
    public class Ticket
    {
        public int TicketId { get; set; } // primary key
        public int EventId { get; set; }   // foeign key
        public int? OrderId { get; set; }
        public string SeatNumber { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int PaymentInfo {  get; set; } //foreign key



        
           



    }
}

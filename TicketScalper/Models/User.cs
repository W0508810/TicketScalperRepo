namespace TicketScalper.Models
{
    public class User
    {
        public int UserId { get; set; } //primary key
        public int UserName { get; set; }
        public string UserPassword { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public int PaymentInfo {  get; set; } 
        public int TicketId { get; set; } //foreign key from Ticket

    }
}

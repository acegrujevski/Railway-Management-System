namespace Railway_Management_System.Models;

public class Ticket
{
    public int Id { get; set; }
    public int ReservationId{ get; set; }
    public Reservation Reservation { get; set; }
    public string TicketNumber {get;set;}
    public decimal Price { get; set; }

}
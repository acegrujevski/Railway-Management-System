namespace Railway_Management_System.Models;

public class Reservation
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public int ScheduleId { get; set; }
    public Schedule Schedule { get; set; }
    public int NumberOfSeats { get; set; }
    public DateTime ReservationDate { get; set; }
    public ReservationStatus Status { get; set; }
}
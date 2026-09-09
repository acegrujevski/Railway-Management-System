namespace Railway_Management_System.Models;

public class Schedule
{
    public int Id { get; set; }
    public int TrainId{ get; set; }
    public Train Train { get; set; }    
    public int RouteId{ get; set; }
    public Route Route { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public decimal Price { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}
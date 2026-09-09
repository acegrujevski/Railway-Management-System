namespace Railway_Management_System.Models;

public class Route
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int StartStationId { get; set; }
    public Station StartStation { get; set; }
    public int EndStationId { get; set; }
    public Station EndStation { get; set; }
    public double Distance { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
}
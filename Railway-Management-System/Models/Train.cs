namespace Railway_Management_System.Models;

public class Train
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string TrainNumber { get; set; }
    public TrainType TrainType { get; set; }
    public int Capacity { get; set; }
    public ICollection<Schedule>  Schedules { get; set; }
    public ICollection<TrainLocation> Locations { get; set; }
}
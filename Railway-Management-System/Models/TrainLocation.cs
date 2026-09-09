namespace Railway_Management_System.Models;

public class TrainLocation
{
    public int Id {get;set;}
    public int TrainId {get;set;}
    public Train Train {get;set;}
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Speed { get; set; }
    public DateTime RecordedAt { get;set; }
}
namespace Sensor;

public class SensorSite
{
    public int Id { get; set; }
    public string? SiteName { get; set; } 
    public string? SiteZone { get; set; } 
    public string? status { get; set; }
    public DateOnly LastContact { get; set; }
}
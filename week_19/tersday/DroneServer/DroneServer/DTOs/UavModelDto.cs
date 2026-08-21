namespace DroneServer.DTOs
{
    public class UavModelDto
    {
        public int model_id { get; set; }
        public string model_name { get; set; }
        public string model_class { get; set; }
        public int max_range_km { get; set; }
        public int endurance_minutes { get; set; }
        public string sensor_payload { get; set; }
    }
}

namespace ReadingsConsumerApi.Models
{
    public class SensorReading
    {
        public string ReadingId { get; set; }
        public decimal Temperature { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

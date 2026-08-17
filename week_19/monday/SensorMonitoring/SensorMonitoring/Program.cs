using SensorMonitoring.Models;
using SensorMonitoring.Services;
const string bootstrapServers = "localhost:9092";
const string topicName = "readings";

var readings = new[]
{
new SensorReading { ReadingId = "101", Temperature = 34, Timestamp = new DateTime(2026, 8, 17, 10, 30, 0) },
new SensorReading { ReadingId = "102", Temperature = 25, Timestamp = new DateTime(2026, 8, 18, 14, 45, 0) },
new SensorReading { ReadingId = "103", Temperature = 28, Timestamp = new DateTime(2026, 8, 18, 14, 45, 0) },
new SensorReading { ReadingId = "104", Temperature = 22, Timestamp = new DateTime(2026, 8, 18, 14, 45, 0) },
new SensorReading { ReadingId = "105", Temperature = 27, Timestamp = new DateTime(2026, 8, 20, 9, 15, 0) }
};
var producerService =new ReadingsProducerService(bootstrapServers, topicName);

foreach (var reading in readings)
{
    await producerService.SendAsync(reading);
    Console.WriteLine($"reading-{reading.ReadingId} sent");
}
producerService.Dispose();
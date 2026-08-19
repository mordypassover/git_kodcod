using Confluent.Kafka;
using preduser.Models;
using System.Text.Json;

const string bootstrapServers = "localhost:9092";
var topics = new[] { "traffic", "weather", "parking" };

var config = new ProducerConfig
{
    BootstrapServers = bootstrapServers
};

var producer = new ProducerBuilder<string, string>(config).Build();

foreach (var topic in topics)
{
    var json = File.ReadAllText($"{topic}-data.json");

    switch (topic)
    {
        case "traffic":
            var trafficEvents = JsonSerializer.Deserialize<TrafficReading[]>(json);

            foreach (var trafficEvent in trafficEvents!)
            {
                var message = new Message<string, string>
                {
                    Value = JsonSerializer.Serialize(trafficEvent)
                };

                producer.Produce(topic, message);
            }
            break;

        case "weather":
            var weatherEvents = JsonSerializer.Deserialize<WeatherReading[]>(json);

            foreach (var weatherEvent in weatherEvents!)
            {
                var message = new Message<string, string>
                {
                    Value = JsonSerializer.Serialize(weatherEvent)
                };

                producer.Produce(topic, message);
            }
            break;

        case "parking":
            var parkingEvents = JsonSerializer.Deserialize<ParkingReading[]>(json);

            foreach (var parkingEvent in parkingEvents!)
            {
                var message = new Message<string, string>
                {
                    Value = JsonSerializer.Serialize(parkingEvent)
                };

                producer.Produce(topic, message);
            }
            break;

        default:
            throw new Exception("Not possible");
    }
}

producer.Flush();
using Confluent.Kafka;
using SensorMonitoring.Models;
using System.Text.Json;
using static Confluent.Kafka.ConfigPropertyNames;


namespace SensorMonitoring.Services;

public class ReadingsProducerService
{
    private readonly IProducer<string, string> _producer;
    private readonly string _topicName;

    public ReadingsProducerService(string bootstrapServers, string topicName)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = bootstrapServers
        };
        _producer = new ProducerBuilder<string, string>(config).Build();
        _topicName = topicName;
    }
    public async Task<DeliveryResult<string, string>> SendAsync(SensorReading reading)
    {
        var key = reading.ReadingId;
        var value = JsonSerializer.Serialize(reading);

        var mesege = new Message<string, string> { Key = key, Value = value };

        var result = await _producer.ProduceAsync(_topicName, mesege);

        return result;
    }
    public void Dispose()
    {
        _producer.Flush(TimeSpan.FromSeconds(10));
        _producer.Dispose();
    }
}

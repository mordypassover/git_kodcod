using Confluent.Kafka;
using ReadingsConsumerApi.Models;
using System.Text.Json;

namespace ReadingsConsumerApi.Services;

public class KafkaConsumerService
{
    private readonly IConsumer<string, string> _consumer;
    private readonly string _topicName;
    public KafkaConsumerService(IConfiguration configuration)
    {
        var bootstrapServers = configuration["Kafka:BootstrapServers"] ?? "localhost:9092";
        var groupId = configuration["Kafka:GroupId"] ?? "orders-api-group";
        _topicName = configuration["Kafka:TopicName"] ?? "readings";
        var config = new ConsumerConfig
        {
            BootstrapServers = bootstrapServers,
            GroupId = groupId,
            AutoOffsetReset = AutoOffsetReset.Earliest
        };
        _consumer = new ConsumerBuilder<string, string>(config).Build();
        _consumer.Subscribe(_topicName);
    }
    public SensorReading? ConsumeNextOrder(TimeSpan timeout)
    {
        try
        {
            var consumeResult = _consumer.Consume(timeout);
            if (consumeResult == null || consumeResult.IsPartitionEOF)
            {
                return null;
            }
            var reading = JsonSerializer.Deserialize<SensorReading>(consumeResult.Message.Value);

            return reading;
        }
        catch (ConsumeException ex)
        {
            return null;
        }
    }
}

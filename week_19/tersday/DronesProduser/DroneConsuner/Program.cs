using Confluent.Kafka;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsetings.json")
    .SetBasePath(Directory.GetCurrentDirectory()).Build();

var config = new ProducerConfig
{
    BootstrapServers = configuration["kafka:BootstrapServers"]
};

var modelsJson = File.ReadAllText("uav_models.json");
var unitsJson = File.ReadAllText("hostile_units.json");
var tracksJson = File.ReadAllText("tracks.json");

var modelsObjects = JsonSerializer.Deserialize<List<Object>>(modelsJson);
var unitsObjects = JsonSerializer.Deserialize<List<Object>>(unitsJson);
var tracksObjects = JsonSerializer.Deserialize<List<Object>>(tracksJson);


using (var producer = new ProducerBuilder<Null, string>(config).Build())
{

    foreach (var model in modelsObjects!)
    {
        var jsonString = JsonSerializer.Serialize(model);

        producer.Produce(configuration["kafka:Topics:Models"], new Message<Null, string> { Value = jsonString });
    }
    producer.Flush();


    foreach (var unit in unitsObjects!)
    {
        var jsonString = JsonSerializer.Serialize(unit);

        producer.Produce(configuration["kafka:Topics:Units"], new Message<Null, string> { Value = jsonString });
    }
    producer.Flush();

    foreach (var track in tracksObjects!)
    {
        var jsonString = JsonSerializer.Serialize(track);

        producer.Produce(configuration["kafka:Topics:Tracks"], new Message<Null, string> { Value = jsonString });
    }
    producer.Flush();

}
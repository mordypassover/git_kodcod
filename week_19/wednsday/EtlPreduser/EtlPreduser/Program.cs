using Confluent.Kafka;
using EtlPreduser.Models;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

var configuration = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json", optional:false)
.Build();

var config = new ProducerConfig()
{
    BootstrapServers = configuration["kafka:BootstrapServers"]
};

var producer = new ProducerBuilder<string, string>(config).Build();

var jsonAnalysts = File.ReadAllText("analysts.json");

var jsonCalls = File.ReadAllText("calls.json");


var analysts = JsonSerializer.Deserialize<Analyst[]>(jsonAnalysts);
var calls = JsonSerializer.Deserialize<Call[]>(jsonCalls);
string messege;

foreach(Analyst analyst in analysts!)
{
    messege = JsonSerializer.Serialize<Analyst>(analyst);
    producer.Produce(configuration["kafka:Topics:analysts"], new Message<string, string> { Value = messege });
}

foreach (Call call in calls!)
{
    messege = JsonSerializer.Serialize<Call>(call);
    producer.Produce(configuration["kafka:Topics:Calls"], new Message<string, string> { Value = messege });
}
producer.Flush(TimeSpan.FromSeconds(10));
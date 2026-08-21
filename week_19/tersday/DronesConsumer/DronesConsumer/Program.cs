
using Confluent.Kafka;
using DronesConsumer.Data;
using DronesConsumer.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using static Confluent.Kafka.ConfigPropertyNames;
using static System.Formats.Asn1.AsnWriter;

namespace DronesConsumer;
public class  Program
{
    public async static Task Main(string[] args)
    { 
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsetings.json")
            .SetBasePath(Directory.GetCurrentDirectory()).Build();


        var services = new ServiceCollection();

        services.AddDbContext<MyDbContext>(options => options
        .UseMySql(configuration["ConnectionStrings:sqlString"], 
        ServerVersion.AutoDetect(configuration["ConnectionStrings:sqlString"])));

        services.AddScoped<KafkaToDbInserter>();

       var serviceProvider = services.BuildServiceProvider();

        using (var scope = serviceProvider.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<MyDbContext>();
            db.Database.EnsureCreated();
        }

        var config = new ConsumerConfig
        {
            BootstrapServers = configuration["Kafka:BootstrapServers"],
            GroupId = configuration["Kafka:GroupId"],
            AutoOffsetReset = AutoOffsetReset.Earliest,
            EnableAutoCommit = false
    
        };
        var consumer = new ConsumerBuilder<Null, string>(config).Build();
    
        
        consumer.Subscribe(configuration["Kafka:Topics:Tracks"]);

        while (true)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var inserter = scope.ServiceProvider.GetRequiredService<KafkaToDbInserter>();

                var incomingJson = consumer.Consume();
                if (incomingJson == null || incomingJson.Message.Value == null)
                {
                    Console.WriteLine("hgfdxz");
                    continue;
                }

                await inserter.ProcessTrack(incomingJson.Message.Value);
            }
        }


    }
}

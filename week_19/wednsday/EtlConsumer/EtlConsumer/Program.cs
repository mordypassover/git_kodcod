using Confluent.Kafka;
using EtlConsumer.Data;
using EtlConsumer.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EtlPreduser;
public class Program
{
    public async static Task Main()
    {
        var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsetings.json", optional: false)
        .Build();

        var services = new ServiceCollection();

        services.AddDbContext<MyDbContaxt>(options =>
            options.UseMySql(
            configuration["ConnectionStrings:sqlString"],
            ServerVersion.AutoDetect(
            configuration["ConnectionStrings:sqlString"])));

        services.AddScoped<KafkaToDbService>();

        var serviceProvider = services.BuildServiceProvider();


        using (var scope = serviceProvider.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<MyDbContaxt>();
            db.Database.EnsureCreated();
        }


        var consumerConfig = new ConsumerConfig
        {
            BootstrapServers = configuration["Kafka:BootstrapServers"],
            GroupId = configuration["Kafka:GroupId"],
            AutoOffsetReset = AutoOffsetReset.Earliest,
            EnableAutoCommit = false
        };
        using var consumer = new ConsumerBuilder<Ignore, string>(consumerConfig).Build();

       
        consumer.Subscribe(configuration["Kafka:Topics:Analysts"]);
        
        while (true)
        {
            var result = consumer.Consume(TimeSpan.FromSeconds(10));
            Console.WriteLine(result);
            // אם לא התקבלו הודעות חדשות במשך 2 שניות - מניחים שטופיק א' הסתיים
            if (result == null || result.Message?.Value == null)
            {
                Console.WriteLine("Finished reading Topic A or reached timeout.");
                break;
            }

            // עיבוד ההודעה
            using var scope = serviceProvider.CreateScope();
            var processingService = scope.ServiceProvider.GetRequiredService <KafkaToDbService>();
            if (await processingService.AddAnalystToDb(result.Message.Value))
            {
                consumer.Commit(result);
            }
        }

        // ============================================
        // שלב 2: התנתקות והמתנה (Timeout / Delay)
        // ============================================
        consumer.Unsubscribe();

        Console.WriteLine("Waiting for delay period...");
        await Task.Delay(TimeSpan.FromSeconds(10)); // זמן ההמתנה שתרצה (TO)

        
        consumer.Subscribe(configuration["Kafka:Topics:Calls"]);
        Console.WriteLine("Consuming Topic B...");

        while (true)
        {
            var result = consumer.Consume(TimeSpan.FromSeconds(1));
            if (result == null || result.Message?.Value == null)
                continue;

            using var scope = serviceProvider.CreateScope();
            var processingService = scope.ServiceProvider.GetRequiredService<KafkaToDbService>();
            if (await processingService.AddCallToDb(result.Message.Value))
            {
                consumer.Commit(result);
            }
        }
    }
}
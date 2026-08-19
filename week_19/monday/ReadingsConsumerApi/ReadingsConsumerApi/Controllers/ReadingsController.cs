using Microsoft.AspNetCore.Mvc;
using ReadingsConsumerApi.Models;
using ReadingsConsumerApi.Services;

namespace ReadingsConsumerApi.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ReadingsController : ControllerBase
{
    private readonly KafkaConsumerService _kafkaConsumer;
    private readonly ILogger<ReadingsController> _logger;
    public ReadingsController(
    KafkaConsumerService kafkaConsumer,
    ILogger<ReadingsController> logger)
    {
        _kafkaConsumer = kafkaConsumer;
        _logger = logger;
    }
    [HttpGet("next")]
    public ActionResult<SensorReading> GetNextOrder()
    {
        _logger.LogInformation("Attempting to consume next order from Kafka");
        var reading = _kafkaConsumer.ConsumeNextOrder(TimeSpan.FromSeconds(5));
        if (reading == null)
        {
            _logger.LogInformation("No orders available");
            return NotFound(new { message = "No orders available" });
        }
        _logger.LogInformation("Order {OrderId} retrieved successfully", reading.ReadingId);
        return Ok(reading);
    }
}
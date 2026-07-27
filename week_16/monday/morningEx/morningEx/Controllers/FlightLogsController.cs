using Microsoft.AspNetCore.Mvc;
using morningEx.Models;
using System.Collections;

namespace morningEx.Controllers;

[ApiController]
[Route("[controller]")]
public class FlightLogsController : ControllerBase
{
    private static readonly List<FlightLog> _flightLogs = new()
    {
        new FlightLog
        {
            Id = 1,
            FlightNumber = "AA101",
            Airline = "American Airlines",
            Destination = "New York JFK",
            PassengerCount = 180,
            ScheduledDeparture = DateTime.UtcNow.AddHours(2),
            Status = "Scheduled"
        },
        new FlightLog
        {
            Id = 2,
            FlightNumber = "BA202",
            Airline = "British Airways",
            Destination = "London Heathrow",
            PassengerCount = 250,
            ScheduledDeparture = DateTime.UtcNow.AddHours(4),
            ActualDeparture = DateTime.UtcNow.AddHours(4).AddMinutes(15),
            Status = "Departed",
            Remarks = "Delayed due to weather"
        },
        new FlightLog
        {
            Id = 3,
            FlightNumber = "LH303",
            Airline = "Lufthansa",
            Destination = "Frankfurt",
            PassengerCount = 200,
            ScheduledDeparture = DateTime.UtcNow.AddHours(6),
            Status = "Scheduled"
        },
        new FlightLog
        {
            Id = 4,
            FlightNumber = "ssew1",
            Airline = "American Airlines",
            Destination = "New York JFK",
            PassengerCount = 10,
            ScheduledDeparture = DateTime.UtcNow.AddHours(3),
            Status = "Scheduled"
        }
    };

    private static int _nextId = 5;

    [HttpGet("Hello")]
    public ActionResult<string> Get()
    {
        return Ok("Hello world");
    }

    [HttpGet]
    public ActionResult<IEnumerable<FlightLog>> GetallFlights()
    {
        return Ok(_flightLogs);
    }

    [HttpGet("{id}")]
    public ActionResult<FlightLog> GetById(int id)
    {
        FlightLog? log = _flightLogs.FirstOrDefault(f => f.Id == id);

        if (log == null) { return NotFound(); }
        else { return Ok(log); }
    }

    [HttpPost]
    public ActionResult<FlightLog> CreateFlightLog(FlightLog flightLog)
    {
        flightLog.Id = _nextId++;
        
        _flightLogs.Add(flightLog);
        
        return CreatedAtAction(
        nameof(GetById),
        new { id = flightLog.Id },
        flightLog);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateLog(int id, FlightLog UpdatedLog)
    {
        var curentLog = _flightLogs.FirstOrDefault(f => f.Id == id);
        
        if (curentLog == null) { return NotFound(); }

        curentLog.FlightNumber = UpdatedLog.FlightNumber;
        curentLog.Airline = UpdatedLog.Airline;
        curentLog.Destination = UpdatedLog.Destination;
        curentLog.PassengerCount = UpdatedLog.PassengerCount;
        curentLog.ScheduledDeparture = UpdatedLog.ScheduledDeparture;
        curentLog.ActualDeparture = UpdatedLog.ActualDeparture;
        curentLog.Remarks = UpdatedLog.Remarks;
        curentLog.Status = UpdatedLog.Status;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteFlightLog(int id)
    {
        var log = _flightLogs.FirstOrDefault(f => f.Id == id );

        if (log == null) { return NotFound(); }

        else 
        { 
            _flightLogs.Remove(log);
            return NoContent();
        }
    }

    [HttpGet("search")]
    public ActionResult<IEnumerable<FlightLog>> SearchByAirline([FromQuery] string airline)
    {
        if (string.IsNullOrWhiteSpace(airline))
        {
            return BadRequest("Airline parameter cannot be empty");
        }
        else
        {
            var logs = _flightLogs.Where(f => f.Airline
            .Contains(airline, StringComparison.OrdinalIgnoreCase)).ToList();
            return Ok(logs);
        }
    }
}

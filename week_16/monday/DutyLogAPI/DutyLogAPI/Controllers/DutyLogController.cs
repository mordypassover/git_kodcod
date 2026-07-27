using DutyLogAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;

namespace DutyLogAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DutyLogController : ControllerBase
{
    private static readonly List<DutyLog> _dutyLogList = new()
    {
        new DutyLog
        {
            Id = 1,
            Name = "Mordy",
            Station = "North Gate",
            ShiftStart = new DateTime(2026, 7, 27, 8, 0, 0),
            ShiftEnd = new DateTime(2026, 7, 27, 16, 0, 0),
            Remarks = "Morning shift. No incidents."
        },
        new DutyLog
        {
            Id = 2,
            Name = "David",
            Station = "Control Room",
            ShiftStart = new DateTime(2026, 7, 27, 16, 0, 0),
            ShiftEnd = new DateTime(2026, 7, 28, 0, 0, 0),
            Remarks = "Evening shift. Routine patrols."
        },
        new DutyLog
        {
            Id = 3,
            Name = "Sarah",
            Station = "Main Entrance",
            ShiftStart = new DateTime(2026, 7, 28, 0, 0, 0),
            ShiftEnd = new DateTime(2026, 7, 28, 8, 0, 0),
            Remarks = "Night shift. One visitor registered."
        },
        new DutyLog
        {
            Id = 4,
            Name = "Eitan",
            Station = "Warehouse",
            ShiftStart = new DateTime(2026, 7, 28, 8, 0, 0),
            ShiftEnd = new DateTime(2026, 7, 28, 16, 0, 0),
            Remarks = "Equipment inspection completed."
        }
    };

    private int _nextId = 5;

    [HttpGet("{id}")]
    public ActionResult<DutyLog> GetById(int id)
    {
        var log = _dutyLogList.FirstOrDefault(l => l.Id == id);

        if (log == null) { return NotFound(); }
        return Ok(log);
    }

    [HttpPost]
    public ActionResult<DutyLog> CreatLog(DutyLog newLog)
    {
        newLog.Id = _nextId++;
        _dutyLogList.Add(newLog);

        return CreatedAtAction(nameof(GetById),
        new { id = newLog.Id },newLog);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateLog(int id, DutyLog UppdatedLog)
    {
        var logToUpdate = _dutyLogList.FirstOrDefault(l => l.Id == id);

        if (logToUpdate == null) { return NotFound(); }
        logToUpdate.Name = UppdatedLog.Name;
        logToUpdate.Station = UppdatedLog.Station;
        logToUpdate.ShiftStart = UppdatedLog.ShiftStart;
        logToUpdate.ShiftEnd = UppdatedLog.ShiftEnd;
        logToUpdate.Remarks = UppdatedLog.Remarks;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteLog(int id)
    {
        var log = _dutyLogList.FirstOrDefault(l => l.Id == id);

        if (log == null) { return NotFound(); }
        
        _dutyLogList.Remove(log);

        return NoContent();


    }
}


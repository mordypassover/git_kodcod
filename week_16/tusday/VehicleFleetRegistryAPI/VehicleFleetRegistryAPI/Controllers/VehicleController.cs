using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using VehicleFleetRegistryAPI.Models;
using VehicleFleetRegistryAPI.Repos;

namespace VehicleFleetRegistryAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VehicleController : ControllerBase
{
    private readonly IVehicleRepo _vehicleRepo;

    public VehicleController(IVehicleRepo vehicleRepo)
    {
        _vehicleRepo = vehicleRepo;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Vehicle>> GetAll()
    {
        return Ok(_vehicleRepo.GetAll());
    }

    [HttpGet("by-id{id}")]
    public ActionResult<Vehicle> GetById(int id)
    {
        var vehicle = _vehicleRepo.GetById(id);

        if (vehicle == null)
        {
            return NotFound();
        }

        return Ok(vehicle);
    }

    [HttpGet("By-RegistrationNumber/{regNumber}")]
    public ActionResult<Vehicle> GetByRegistrationNumber(string regNumber)
    {
        var vehicle = _vehicleRepo.GetByRegistrationNumber(regNumber);

        if (vehicle == null)
        {
            return NotFound();
        }

        return Ok(vehicle);
    }

    [HttpGet("By-status/{status}")]
    public ActionResult<IEnumerable<Vehicle>> GetByStatus(string status)
    {
        return Ok(_vehicleRepo.GetByStatus(status));
    }

    [HttpGet("type/{type}")]
    public ActionResult<IEnumerable<Vehicle>> GetByType(string type)
    {
        return Ok(_vehicleRepo.GetByType(type));
    }

    [HttpPost]
    public ActionResult Create(Vehicle vehicle)
    {
        var added = _vehicleRepo.Create(vehicle);
        return CreatedAtAction(nameof(GetById), new { id = added.Id }, added);
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id,Vehicle vehicle)
    {
        var updated = _vehicleRepo.Update(id, vehicle);

        if (updated == null)
        {
            return NotFound();
        }
        return NoContent();
    }
    [HttpDelete]
    public ActionResult Delete(int id)
    {
        var deleted = _vehicleRepo.Delete(id);

        if (! deleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}

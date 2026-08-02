using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Expressions;
using SatelliteTelemetryAnalyzerAPI.Models;
using SatelliteTelemetryAnalyzerAPI.repositorys;
using System;
using System.Threading.Tasks;

namespace SatelliteTelemetryAnalyzerAPI.Controllers;

[ApiController]
[Route("/api/satellites/[controller]")]
public class SatellitesController : ControllerBase
{
    private readonly ISatelliteRepository _repo;
    public SatellitesController(ISatelliteRepository repo)
    {
        _repo = repo;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Satellite>>> Get()
    {
        return  Ok(await _repo.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Satellite>> GetById(int id)
    {
        var satellite = await _repo.GetByIdAsync(id);

        if(satellite == null) 
        {
            return NotFound(); 
        }

        return satellite;
    }

    [HttpPost]
    public async Task<ActionResult<Satellite>> Creat(Satellite satellite)
    {
        var newSatellite = await _repo.CreateAsync(satellite);

        return CreatedAtAction(nameof(GetById), new { id = satellite.Id }, satellite);
    }
}
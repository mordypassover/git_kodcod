using DronesConsumer.Data;
using DronesConsumer.Models;
using DroneServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DroneServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DroneController: ControllerBase
    {
        private readonly MyDbContext _dbContext;

        public DroneController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("Models/")]
        public async Task<ActionResult<IEnumerable<UavModelDto>>> GetAllModelsAsync()
        {
            var result = _dbContext.Models
                .Select(m => new UavModelDto 
                {
                model_id = m.model_id,
                model_name = m.model_name,
                model_class = m.model_class,
                max_range_km = m.max_range_km,
                endurance_minutes = m.endurance_minutes,
                sensor_payload = m.sensor_payload
                });

            return await result.ToListAsync();
        }


    }
}

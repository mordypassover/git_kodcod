using Microsoft.AspNetCore.Mvc;
using Sensor;
using System.Collections;
using System.Xml.Linq;

namespace SelfApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SensorSiteController : ControllerBase
    {
        private static readonly List<SensorSite> _sensorSitesList = new()
        {
            new SensorSite
            {
                Id = 1,
                SiteName = "dc-2",
                SiteZone = "North",
                status = "silent",
                LastContact = new DateOnly(2023, 4, 12)
            },
            new SensorSite
            {
                Id = 2,
                SiteName = "c-12",
                SiteZone = "West",
                status = "active,",
                LastContact = new DateOnly(2023, 4, 12)
            },
            new SensorSite
            {
                Id = 3,
                SiteName = "xx-300",
                SiteZone = "East",
                status = "maintenance),",
                LastContact = new DateOnly(2023, 4, 12)
            },
            new SensorSite
            {
                Id = 4,
                SiteName = "RD2",
                SiteZone = "West",
                status = "active,",
                LastContact = new DateOnly(2023, 4, 12)
            },
            new SensorSite
            {
                Id = 5,
                SiteName = "ddp",
                SiteZone = "North",
                status = "silent",
                LastContact = new DateOnly(2023, 4, 12)
            },
            new SensorSite
            {
                Id = 6,
                SiteName = "cww-qw",
                SiteZone = "West",
                status = "maintenance),",
                LastContact = new DateOnly(2023, 4, 12)
            },new SensorSite
            {
                Id = 7,
                SiteName = "dc-2",
                SiteZone = "East",
                status = "active,",
                LastContact = new DateOnly(2023, 4, 12)
            },
            new SensorSite
            {
                Id = 8,
                SiteName = "aa-88",
                SiteZone = "West",
                status = "silent",
                LastContact = new DateOnly(2023, 4, 12)
            }
        };

        [HttpGet("all")]
        public ActionResult<IEnumerable<SensorSite>> Get()
        {
            return Ok(_sensorSitesList);
        }


        [HttpGet("{id}")]
        public ActionResult<SensorSite> getById(int id)
        {
            var site = _sensorSitesList.FirstOrDefault(s => s.Id == id);


            if (site == null){return NotFound($"id {id} not found");}
                
            else { return site; }
        }


        [HttpGet("find")]
        public ActionResult<IEnumerable<SensorSite>>
        FindByZone([FromQuery] string serchZone)
        {
            List<SensorSite> inZone = _sensorSitesList.Where(s => s.SiteZone == serchZone).ToList();
            return inZone;
        }
        
    }
}
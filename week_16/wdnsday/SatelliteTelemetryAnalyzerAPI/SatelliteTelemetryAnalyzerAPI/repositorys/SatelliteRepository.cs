using SatelliteTelemetryAnalyzerAPI.Models;
using System.Threading.Tasks;

namespace SatelliteTelemetryAnalyzerAPI.repositorys;

public class SatelliteRepository:ISatelliteRepository
{
    private readonly List<Satellite> _satellites;
    private int _nextId;

    public SatelliteRepository()
    {
        _satellites = new() 
        {
             new Satellite
            {
                Id = 1,
                Name = "Hubble Space Telescope",
                OrbitAltitudeKm = 540,
                Status = "Active"
            },
            new Satellite
            {
                Id = 2,
                Name = "Weather Observer 1",
                OrbitAltitudeKm = 850,
                Status = "Standby"
            },
            new Satellite
            {
                Id = 3,
                Name = "GPS Navigation A",
                OrbitAltitudeKm = 20200,
                Status = "Active"
            },
            new Satellite
            {
                Id = 4,
                Name = "Old Communication Sat",
                OrbitAltitudeKm = 35786,
                Status = "Decommissioned"
            },
            new Satellite
            {
                Id = 5,
                Name = "Earth Imaging X",
                OrbitAltitudeKm = 700,
                Status = "Active"
            }
        };
    }

    public async Task<IEnumerable<Satellite>> GetAllAsync()
    {
        await Task.Delay(10);
        return _satellites;
    }
    public async Task<Satellite?> GetByIdAsync(int id)
    {
        await Task.Delay(10);
        return _satellites.FirstOrDefault(s => s.Id == id);
    }

    public async Task<Satellite> CreateAsync(Satellite satellite)
    {
        await Task.Delay(10);
        satellite.Id = _nextId++;

        return satellite;
    }
     
    public async Task<bool> UpdateAsync(int id, Satellite satellite)
    {
        await Task.Delay(10);
        var unupdated =await GetByIdAsync(id);

        if (unupdated == null)
        {
            return false;
        }
        unupdated.Name = satellite.Name;
        unupdated.OrbitAltitudeKm = satellite.OrbitAltitudeKm;
        unupdated.Status = satellite.Status;
        return true;
    }
}

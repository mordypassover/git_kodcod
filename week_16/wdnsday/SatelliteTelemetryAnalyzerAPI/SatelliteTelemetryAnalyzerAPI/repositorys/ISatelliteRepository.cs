using Microsoft.AspNetCore.Http.HttpResults;
using SatelliteTelemetryAnalyzerAPI.Models;

namespace SatelliteTelemetryAnalyzerAPI.repositorys
{
    public interface ISatelliteRepository
    {
        Task<IEnumerable<Satellite>> GetAllAsync();
        Task<Satellite?> GetByIdAsync(int id);
        Task<Satellite> CreateAsync(Satellite satellite);
        Task<bool> UpdateAsync(int id, Satellite satellite);
    }
}

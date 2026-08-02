using SatelliteTelemetryAnalyzerAPI.Models;

namespace SatelliteTelemetryAnalyzerAPI.repositorys
{
    public interface ITelemetryRepository
    {
        Task<IEnumerable<TelemetryReport>> GetAllAsync();
        Task<TelemetryReport?> GetByIdAsync(int id);
        Task<IEnumerable<TelemetryReport>> GetBySatelliteIdAsync(int satelliteId);
        Task<TelemetryReport> SubmitAsync(TelemetryReport request);
        
    }
}

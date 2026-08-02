using SatelliteTelemetryAnalyzerAPI.Models;
using System.Net.NetworkInformation;

namespace SatelliteTelemetryAnalyzerAPI.repositorys;

public class TelemetryRepository : ITelemetryRepository
{
    private readonly List<TelemetryReport> _reports;
    private int _nexrtReportId;
    public TelemetryRepository()
    {
        _reports = new();
        _nexrtReportId = 1;
    }

    public async Task<IEnumerable<TelemetryReport>> GetAllAsync()
    {
        await Task.Delay(10);
        return _reports;
    }
    public async Task<TelemetryReport?> GetByIdAsync(int id)
    {
        await Task.Delay(10);
        return _reports.FirstOrDefault(s => s.Id == id);
    }

    public async Task<IEnumerable<TelemetryReport>> GetBySatelliteIdAsync(int satelliteId)
    {
        await Task.Delay(10);
        return _reports.Where(s => s.SatelliteId == satelliteId);
    }
    public async Task<TelemetryReport> SubmitAsync(TelemetryReport request)
    {
        await Task.Delay(10);
        request.Id = _nexrtReportId++;
        _reports.Add(request);

        return request;
    }
}

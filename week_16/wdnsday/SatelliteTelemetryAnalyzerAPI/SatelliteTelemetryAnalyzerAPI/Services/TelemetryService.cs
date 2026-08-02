using SatelliteTelemetryAnalyzerAPI.Models;
using SatelliteTelemetryAnalyzerAPI.repositorys;

namespace SatelliteTelemetryAnalyzerAPI.Services;

public class TelemetryService:ITelemetryService
{
    private readonly ISatelliteRepository _satelliteRepo;
    private readonly ITelemetryRepository _telemetryRepo;

    public TelemetryService(ISatelliteRepository satelliteRepo, ITelemetryRepository telemetryRepo)
    {
        _satelliteRepo = satelliteRepo;
        _telemetryRepo = telemetryRepo;
    }

    public async Task<IEnumerable<TelemetryReport>> GetAllReportsAsync()
    {
        return await _telemetryRepo.GetAllAsync();
    }

    public async Task<TelemetryReport?> GetReportByIdAsync(int id)
    {
        return await _telemetryRepo.GetByIdAsync(id);
    }
    public async Task<TelemetryReport?> SubmitTelemetryAsync(SubmitTelemetryRequest request)
    {
        if (request.BatteryPercent < 10)
        {
            return null;
        }
        if (request.TemperatureCelsius < -50 || request.TemperatureCelsius > 60)
        {
            return null;
        }
        if (request.SignalStrengthDb < -100)
        {
            return null;
        }
        TelemetryReport newReport = new()
        {
            SatelliteId = request.SatelliteId,
            BatteryPercent = request.BatteryPercent,
            TemperatureCelsius = request.TemperatureCelsius,
            SignalStrengthDb = request.SignalStrengthDb
        };

    }
}

using VehicleFleetRegistryAPI.Models;

namespace VehicleFleetRegistryAPI.Repos
{
    public interface IVehicleRepo
    {
        List<Vehicle> GetAll();
        Vehicle? GetById(int id);
        Vehicle? GetByRegistrationNumber(string regNumber);
        List<Vehicle> GetByStatus(string status);
        List<Vehicle> GetByType(string type);
        Vehicle Create(Vehicle vehicle);
        Vehicle? Update(int id, Vehicle vehicle);
        bool Delete(int id);
    }
}

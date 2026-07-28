using System.Net.NetworkInformation;
using VehicleFleetRegistryAPI.Models;

namespace VehicleFleetRegistryAPI.Repos
{
    public class VehicleRepo : IVehicleRepo
    {
        private readonly List<Vehicle> _vehicles;
        private int _nextId;

        public VehicleRepo()
        {
            _vehicles = new()
            {
                new Vehicle
                {
                    Id = 1,
                    RegistrationNumber = "10001",
                    VehicleType = "Truck",
                    Status = "Available",
                    AssignedDriver = "John Smith",
                    CurrentLocation = "New York Depot",
                    Mileage = 45200
                },
                new Vehicle
                {
                    Id = 2,
                    RegistrationNumber = "10002",
                    VehicleType = "Jeep",
                    Status = "In-Use",
                    AssignedDriver = "Sarah Johnson",
                    CurrentLocation = "Sector A",
                    Mileage = 78120
                },
                new Vehicle
                {
                    Id = 3,
                    RegistrationNumber = "10003",
                    VehicleType = "Ambulance",
                    Status = "Maintenance",
                    AssignedDriver = "Michael Brown",
                    CurrentLocation = "Service Center",
                    Mileage = 125000
                },
                new Vehicle
                {
                    Id = 4,
                    RegistrationNumber = "10004",
                    VehicleType = "SUV",
                    Status = "Available",
                    AssignedDriver = null,
                    CurrentLocation = "Main Garage",
                    Mileage = 15400
                },
                new Vehicle
                {
                    Id = 5,
                    RegistrationNumber = "10005",
                    VehicleType = "Motorcycle",
                    Status = "In-Use",
                    AssignedDriver = "Emily Davis",
                    CurrentLocation = "Checkpoint Bravo",
                    Mileage = 9300
                },
                new Vehicle
                {
                    Id = 6,
                    RegistrationNumber = "10006",
                    VehicleType = "Van",
                    Status = "Decommissioned",
                    AssignedDriver = null,
                    CurrentLocation = "Storage Yard",
                    Mileage = 312450
                },
                new Vehicle
                {
                    Id = 7,
                    RegistrationNumber = "10007",
                    VehicleType = "Bus",
                    Status = "Available",
                    AssignedDriver = "David Wilson",
                    CurrentLocation = "Central Station",
                    Mileage = 210800
                },
                new Vehicle
                {
                    Id = 8,
                    RegistrationNumber = "10008",
                    VehicleType = "Pickup",
                    Status = "Maintenance",
                    AssignedDriver = "Olivia Martinez",
                    CurrentLocation = "Repair Workshop",
                    Mileage = 68750
                }
            };

            _nextId = _vehicles.Count + 1;

        }

        public List<Vehicle> GetAll()
        {
            return _vehicles;
        }

        public Vehicle? GetById(int id)
        {
            var vehicle = _vehicles.FirstOrDefault(v => v.Id == id);

            return vehicle;
        }

        public Vehicle? GetByRegistrationNumber(string regNumber)
        {
            var vehicle = _vehicles.FirstOrDefault(v => v.RegistrationNumber == regNumber);

            return vehicle;
        }

        public List<Vehicle> GetByStatus(string status)
        {
            return _vehicles.Where(r => r.Status == status).ToList();
        }

        public List<Vehicle> GetByType(string type)
        {
            return _vehicles.Where(r => r.VehicleType == type).ToList();
        }

        public Vehicle Create(Vehicle vehicle)
        {
            vehicle.Id = _nextId++;
            _vehicles.Add(vehicle);

            return vehicle;
        }

        public Vehicle? Update(int id, Vehicle vehicle)
        {
            var oldVehicle = GetById(id);
            if (oldVehicle == null)
            {
                return null;
            }
            oldVehicle.RegistrationNumber = vehicle.RegistrationNumber;
            oldVehicle.VehicleType = vehicle.VehicleType;
            oldVehicle.Status = vehicle.Status;
            oldVehicle.AssignedDriver = vehicle.AssignedDriver;
            oldVehicle.CurrentLocation = vehicle.CurrentLocation;
            oldVehicle.Mileage = vehicle.Mileage;

            return oldVehicle;

        }

        public bool Delete(int id)
        {
            var vehicle = GetById(id);
            if( vehicle == null)
            {
                return false;
            }
            _vehicles.Remove(vehicle);
            return true;
        }
    }
}

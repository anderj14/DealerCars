using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IVehicleRepository
    {
        ICollection<Vehicle> GetVehicles();
        Vehicle GetVehicle(int id);
        Vehicle GetVIN(string VIN);
        bool GetVehicleExists(int vehicleId);

        void CreateVehicle(Vehicle vehicle);
        void UpdateVehicle(Vehicle vehicle);
        void DeleteVehicle(Vehicle vehicle);
        void Save();
    }
}

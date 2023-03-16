using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IVehicleRepository
    {
        ICollection<Vehicle> GetVehicles();
        Vehicle GetVehicle(int id);
        Vehicle GetVehicle(string name);
        bool GetVehicleExists(int vehicleId);
    }
}

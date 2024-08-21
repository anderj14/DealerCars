using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IFuelRepository
    {
        ICollection<Fuel> GetFuels();
        Fuel GetFuel(int id);
        ICollection<Vehicle> GetVehicleByFuel(int fueldId);
        bool FuelExists(int id);

        void CreateFuel(Fuel fuel);
        void UpdateFuel(Fuel fuel);
        void DeleteFuel(Fuel fuel);
        void Save();
    }
}

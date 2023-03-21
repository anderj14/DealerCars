using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IEngineRepository
    {
        ICollection<Engine> GetEngines();
        Engine GetEngine(int engineId);
        ICollection<Vehicle> GetVehicleByEngine(int engineId);
        bool EngineExists(int engineId);
    }
}

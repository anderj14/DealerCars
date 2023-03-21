using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IStatusRepository
    {
        ICollection<Status> GetStatuses();
        Status GetStatus(int statusId);
        ICollection<Vehicle> GetVehiclesByStatus(int statusId);
        bool StatusExists(int statusId);
    }
}

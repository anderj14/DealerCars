using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IStatusRepository
    {
        ICollection<Status> GetStatuses();
        Status GetStatus(int statusId);
        bool StatusExists(int statusId);

        void CreateStatus(Status status);
        void UpdateStatus(Status status);
        void DeleteStatus(Status status);
        void Save();
    }
}

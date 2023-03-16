using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface ITypesRepository
    {
        ICollection<Types> GetTypes();
        Types GetType(int typeId);
        bool GetTypeExists(int typeId);
    }
}

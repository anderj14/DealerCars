using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IModelRepository
    {
        ICollection<Models> GetModels();
        Models GetModel(int modelId);
        ICollection<Types> GetTypeByModel(int brandId);
        bool ModelExists(int modelId);
    }
}

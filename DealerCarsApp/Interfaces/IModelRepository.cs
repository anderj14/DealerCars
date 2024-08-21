using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IModelRepository
    {
        ICollection<Models> GetModels();
        Models GetModel(int modelId);
        bool ModelExists(int modelId);

        void CreateModel(Models models);
        void UpdateModel(Models models);
        void DeleteModel(Models models);
        void Save();
    }
}

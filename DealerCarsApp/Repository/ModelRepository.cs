using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;

namespace DealerCarsApp.Repository
{
    public class ModelRepository : IModelRepository
    {
        private readonly DataContext _context;

        public ModelRepository(DataContext context)
        {
            _context = context;
        }
        public bool ModelExists(int modelId)
        {
            return _context.Models.Any(m => m.Id == modelId);
        }

        public Models GetModel(int modelId)
        {
            return _context.Models.Where(m => m.Id == modelId).FirstOrDefault();
        }

        public ICollection<Models> GetModels()
        {
            return _context.Models.ToList();
        }

        public void CreateModel(Models models)
        {
            _context.Models.Add(models);
            Save();
        }

        public void UpdateModel(Models models)
        {
            _context.Models.Update(models);
            Save();
        }

        public void DeleteModel(Models models)
        {
            _context.Models.Remove(models);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

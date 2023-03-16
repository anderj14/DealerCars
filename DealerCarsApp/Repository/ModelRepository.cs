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

        public ICollection<Types> GetTypeByModel(int modelId)
        {
            return _context.Types.Where(t => t.Model.Id == modelId).ToList();
        }
    }
}

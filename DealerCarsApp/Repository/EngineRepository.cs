using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;

namespace DealerCarsApp.Repository
{
    public class EngineRepository : IEngineRepository
    {
        private readonly DataContext _context;
        public EngineRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Engine> GetEngines()
        {
            return _context.Engines.ToList();
        }
        public Engine GetEngine(int engineId)
        {
            return _context.Engines.Where(e => e.Id == engineId).FirstOrDefault();
        }

        public bool EngineExists(int engineId)
        {
            return _context.Engines.Any(e => e.Id != engineId);
        }

        public void CreateEngine(Engine engine)
        {
            _context.Engines.Add(engine);
            Save();
        }

        public void UpdateEngine(Engine engine)
        {
            _context.Engines.Update(engine);
            Save();
        }

        public void DeleteEngine(Engine engine)
        {
            _context.Engines.Remove(engine);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;

namespace DealerCarsApp.Repository
{
    public class TypesRepository : ITypesRepository
    {
        private readonly DataContext _context;

        public TypesRepository(DataContext context)
        {
            _context = context;
        }
        public Types GetType(int typeId)
        {
            return _context.Types.Where(t => t.Id == typeId).FirstOrDefault();
        }

        public ICollection<Types> GetTypes()
        {
            return _context.Types.ToList();
        }

        public bool GetTypeExists(int typeId)
        {
            return _context.Types.OrderBy(t => t.Id == typeId).Any();
        }
    }
}

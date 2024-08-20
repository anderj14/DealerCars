using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;

namespace DealerCarsApp.Repository
{
    public class TrimRepository : ITrimRepository
    {
        private readonly DataContext _context;

        public TrimRepository(DataContext context)
        {
            _context = context;
        }
        public Trim GetTrim(int typeId)
        {
            return _context.Trims.Where(t => t.Id == typeId).FirstOrDefault();
        }

        public ICollection<Trim> GetTrims()
        {
            return _context.Trims.ToList();
        }

        public bool GetTrimExists(int typeId)
        {
            return _context.Trims.OrderBy(t => t.Id == typeId).Any();
        }
    }
}

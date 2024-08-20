using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;

namespace DealerCarsApp.Repository
{
    public class BodyStyleRepository : IBodyStyleRepository
    {
        private readonly DataContext _context;

        public BodyStyleRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<BodyStyle> GetBodyStyles()
        {
            return _context.BodyStyles.ToList();
        }

        public BodyStyle GetBodyStyle(int bodyStyleId)
        {
            return _context.BodyStyles.Where(b => b.Id == bodyStyleId).FirstOrDefault();
        }

        public bool BodyStyleExists(int id)
        {
            return _context.BodyStyles.Any(b => b.Id == id);
        }

    }
}

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

        public void CreateBodyStyle(BodyStyle bodyStyle)
        {
            _context.BodyStyles.Add(bodyStyle);
            Save();
        }

        public void UpdateBodyStyle(BodyStyle bodyStyle)
        {
            _context.BodyStyles.Update(bodyStyle);
            Save();
        }

        public void DeleteBodyStyle(BodyStyle bodyStyle)
        {
            _context.BodyStyles.Remove(bodyStyle);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

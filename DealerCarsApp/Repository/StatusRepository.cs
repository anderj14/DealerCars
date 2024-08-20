using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;

namespace DealerCarsApp.Repository
{
    public class StatusRepository : IStatusRepository
    {
        private readonly DataContext _context;

        public StatusRepository(DataContext context)
        {
            _context= context;
        }

        public ICollection<Status> GetStatuses()
        {
            return _context.Statuses.ToList();
        }
        public Status GetStatus(int statusId)
        {
            return _context.Statuses.Where(s => s.Id == statusId).FirstOrDefault();
        }

        public bool StatusExists(int statusId)
        {
            return _context.Statuses.Any();
        }
    }
}

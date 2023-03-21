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
            return _context.Status.ToList();
        }
        public Status GetStatus(int statusId)
        {
            return _context.Status.Where(s => s.Id == statusId).FirstOrDefault();
        }
        public ICollection<Vehicle> GetVehiclesByStatus(int statusId)
        {
            return  _context.Vehicles.Where(s => s.Status.Id== statusId).ToList();
        }

        public bool StatusExists(int statusId)
        {
            return _context.Status.Any();
        }
    }
}

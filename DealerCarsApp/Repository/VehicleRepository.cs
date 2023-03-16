using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;

namespace DealerCarsApp.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly DataContext _context;

        public VehicleRepository( DataContext context)
        {
            _context = context;
        }

        public Vehicle GetVehicle(int id)
        {
            return _context.Vehicles.Where(v => v.Id == id).FirstOrDefault();
        }

        public Vehicle GetVehicle(string name)
        {
            return _context.Vehicles.Where(v => v.Name == name).FirstOrDefault();
        }

        public bool GetVehicleExists(int vehicleId)
        {
            return _context.Vehicles.OrderBy(v => v.Id == vehicleId).Any();
        }

        public ICollection<Vehicle> GetVehicles()
        {
            return _context.Vehicles.OrderBy(v => v.Id).ToList();
        }
    }
}

using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;

namespace DealerCarsApp.Repository
{
    public class FuelRepository : IFuelRepository
    {
        private readonly DataContext _context;

        public FuelRepository(DataContext context)
        {
            _context = context;
        }
        public bool FuelExists(int id)
        {
            return _context.Fuel.Any(f => f.Id == id);
        }

        public Fuel GetFuel(int id)
        {
            return _context.Fuel.Where(f => f.Id == id).FirstOrDefault();
        }

        public ICollection<Fuel> GetFuels()
        {
            return _context.Fuel.ToList();
        }

        public ICollection<Vehicle> GetVehicleByFuel(int fueldId)
        {
            return _context.VehicleFuelTypes.Where(f => f.FuelTypeId == fueldId).Select(v => v.Vehicle).ToList();
        }
    }
}

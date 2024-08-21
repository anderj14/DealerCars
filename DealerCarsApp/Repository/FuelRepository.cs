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
            return _context.Fuels.Any(f => f.Id == id);
        }

        public Fuel GetFuel(int id)
        {
            return _context.Fuels.Find(id);
        }

        public ICollection<Fuel> GetFuels()
        {
            return _context.Fuels.ToList();
        }

        public ICollection<Vehicle> GetVehicleByFuel(int fuelId)
        {
            return _context.Vehicles
                           .Where(v => v.FuelId == fuelId)
                           .ToList();
        }

        public void CreateFuel(Fuel fuel)
        {
            _context.Fuels.Add(fuel);
            Save();
        }

        public void UpdateFuel(Fuel fuel)
        {
            _context.Fuels.Update(fuel);
            Save();
        }

        public void DeleteFuel(Fuel fuel)
        {
            _context.Fuels.Remove(fuel);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

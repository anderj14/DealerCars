using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;
using Microsoft.EntityFrameworkCore;

namespace DealerCarsApp.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly DataContext _context;

        public VehicleRepository(DataContext context)
        {
            _context = context;
        }

        public Vehicle GetVehicle(int id)
        {
            return _context.Vehicles
                            .Include(v => v.Brand)
                            .Include(v => v.Models)
                            .Include(v => v.Status)
                            .Include(v => v.BodyStyle)
                            .Include(v => v.Engine)
                            .Include(v => v.DriveTrain)
                            .Include(v => v.Fuel)
                            .Where(v => v.Id == id).FirstOrDefault();
        }

        public bool GetVehicleExists(int vehicleId)
        {
            return _context.Vehicles.OrderBy(v => v.Id == vehicleId).Any();
        }

        public ICollection<Vehicle> GetVehicles()
        {
            return _context.Vehicles
                            .Include(v => v.Brand)
                            .Include(v => v.Models)
                            .Include(v => v.Status)
                            .Include(v => v.BodyStyle)
                            .Include(v => v.Engine)
                            .Include(v => v.DriveTrain)
                            .Include(v => v.Fuel)
                            .OrderBy(v => v.Id).ToList();
        }

        public void CreateVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            Save();
        }
        public void UpdateVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Update(vehicle);
            Save();
        }

        public void DeleteVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Remove(vehicle);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Vehicle GetVIN(string VIN)
        {
            return _context.Vehicles
                            .Include(v => v.Brand)
                            .Include(v => v.Models)
                            .Include(v => v.Status)
                            .Include(v => v.BodyStyle)
                            .Include(v => v.Engine)
                            .Include(v => v.DriveTrain)
                            .Include(v => v.Fuel)
                            .Where(v => v.VIN == VIN).FirstOrDefault();
        }
    }
}

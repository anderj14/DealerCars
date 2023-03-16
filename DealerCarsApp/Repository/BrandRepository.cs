using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;

namespace DealerCarsApp.Repository
{
    public class BrandRepository : IBrandRepository
    {
        private readonly DataContext _context;

        public BrandRepository(DataContext context)
        {
            _context = context;
        }

        public bool BrandExists(int id)
        {
            return _context.Brands.Any(b => b.Id == id);
        }

        public Brand GetBrand(int id)
        {
            return _context.Brands.Where(b => b.Id == id).FirstOrDefault();
        }

        public ICollection<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public ICollection<Models> GetModelsByBrand(int brandId)
        {
            return _context.Models.Where(m => m.Brand.Id == brandId).ToList();
        }

        public ICollection<Vehicle> GetVehicleByBrand(int brandId)
        {
            return _context.VehicleBrands.Where(b => b.BrandId == brandId).Select(v => v.Vehicle).ToList();

        }
    }
}

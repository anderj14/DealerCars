using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;
using Microsoft.EntityFrameworkCore;

namespace DealerCarsApp.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly DataContext _context;

        public BrandRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Brand> GetBrands()
        {
            return _context.Brands
                           .Include(b => b.Models)
                           .ToList();
        }

        public Brand GetBrand(int id)
        {
            return _context.Brands
                           .Include(b => b.Models)
                           .FirstOrDefault(b => b.Id == id);
        }

        public ICollection<Vehicle> GetVehiclesByBrand(int brandId)
        {
            return _context.Vehicles
                           .Where(v => v.BrandId == brandId)
                           .ToList();
        }

        public ICollection<Models> GetModelsByBrand(int brandId)
        {
            var brand = _context.Brands
                                .Include(b => b.Models)
                                .FirstOrDefault(b => b.Id == brandId);

            return brand != null ? brand.Models : new List<Models>();
        }

        public bool BrandExists(int id)
        {
            return _context.Brands.Any(b => b.Id == id);
        }
    }
}

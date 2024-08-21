using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IBrandRepository
    {
        ICollection<Brand> GetBrands();
        Brand GetBrand(int id);
        ICollection<Vehicle> GetVehiclesByBrand(int brandId);
        ICollection<Models> GetModelsByBrand(int brandId);
        bool BrandExists(int id);

        void CreateBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
        void Save();
    }
}

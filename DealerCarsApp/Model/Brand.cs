namespace DealerCarsApp.Model
{
    public class Brand: BaseEntity
    {
        public string? BrandName { get; set; }
        public ICollection<VehicleBrand> VehicleBrands { get; set; }
    }
}

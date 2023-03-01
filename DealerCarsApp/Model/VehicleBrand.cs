namespace DealerCarsApp.Model
{
    public class VehicleBrand
    {
        public int VehicleId { get; set; }
        public int BrandId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Brand Brand { get; set; }
    }
}

namespace DealerCarsApp.Model
{
    public class Fuel: BaseEntity
    {
        public string FuelType { get; set; }
        public ICollection<VehicleFuelType> VehicleFuelTypes { get; set; }
    }
}

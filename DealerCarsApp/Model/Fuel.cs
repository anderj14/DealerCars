namespace DealerCarsApp.Model
{
    public class Fuel: BaseEntity
    {
        public string FuelName { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}

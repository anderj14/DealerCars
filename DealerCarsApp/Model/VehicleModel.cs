namespace DealerCarsApp.Model
{
    public class VehicleModel
    {
        public int VehicleId { get; set; }
        public int ModelId { get; set; }
        public Vehicle Vehicles { get; set; }
        public Model Models { get; set; }
    }
}

namespace DealerCarsApp.Model
{
    public class VehicleModel
    {
        public int VehicleId { get; set; }
        public int ModelId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Models Model { get; set; }
    }
}

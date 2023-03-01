namespace DealerCarsApp.Model
{
    public class VehicleFuelType
    {
        public int VehicleId { get; set; }
        public int FuelTypeId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Fuel Fuel { get; set; }

    }   
}

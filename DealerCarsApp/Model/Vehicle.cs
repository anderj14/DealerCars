namespace DealerCarsApp.Model
{
    public class Vehicle: BaseEntity
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int Mileage { get; set; }
        public Status Status { get; set; }
        public BodyStyle BodyStyle { get; set; }
        public Engine Engine { get; set; }
        public DriveTrain DriveTrain { get; set; }
        public ICollection<VehicleBrand> VehicleBrands { get; set;}
        public ICollection<VehicleModel> VehicleModels { get; set;}
        public ICollection<VehicleFuelType> VehicleFuelTypes { get; set;}
    }
}

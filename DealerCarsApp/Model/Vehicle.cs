namespace DealerCarsApp.Model
{
    public class Vehicle: BaseEntity
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public int Mileage { get; set; }
        public Status Status { get; set; }
        public BodyStyle BodyStyle { get; set; }
        public Engine Engine { get; set; }
        public DriveTrain DriveTrain { get; set; }
        public Brand Brand { get; set; }
        public ICollection<VehicleFuelType> VehicleFuelTypes { get; set;}
    }
}

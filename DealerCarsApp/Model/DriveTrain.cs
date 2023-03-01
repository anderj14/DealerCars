namespace DealerCarsApp.Model
{
    public class DriveTrain: BaseEntity
    {
        public string DriveTrainType { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}

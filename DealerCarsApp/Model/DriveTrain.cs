namespace DealerCarsApp.Model
{
    public class DriveTrain: BaseEntity
    {
        public string DriveTrainName { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}

namespace DealerCarsApp.Model
{
    public class BodyStyle: BaseEntity
    {
        public string BodyType { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}

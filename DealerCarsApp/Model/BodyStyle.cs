namespace DealerCarsApp.Model
{
    public class BodyStyle: BaseEntity
    {
        public string BodyTypeName { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}

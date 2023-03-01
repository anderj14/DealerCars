namespace DealerCarsApp.Model
{
    public class Engine: BaseEntity
    {
        public string EngineType { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}

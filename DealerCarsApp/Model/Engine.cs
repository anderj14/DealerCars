namespace DealerCarsApp.Model
{
    public class Engine: BaseEntity
    {
        public string EngineTypeName { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}

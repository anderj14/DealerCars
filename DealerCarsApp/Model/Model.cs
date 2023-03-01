namespace DealerCarsApp.Model
{
    public class Model: BaseEntity
    {
        public string ModelName { get; set; }
        public Type Type { get; set; }
        public ICollection<VehicleModel> VehicleModels { get; set; }

    }
}

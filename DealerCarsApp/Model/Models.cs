namespace DealerCarsApp.Model
{
    public class Models: BaseEntity
    {
        public string ModelName { get; set; }
        public Types Type { get; set; }
        public ICollection<VehicleModel> VehicleModels { get; set; }

    }
}

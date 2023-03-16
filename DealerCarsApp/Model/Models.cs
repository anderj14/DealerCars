namespace DealerCarsApp.Model
{
    public class Models: BaseEntity
    {
        public string ModelName { get; set; }
        public Brand Brand { get; set; }
        public ICollection<Types> Types { get; set; }
    }
}

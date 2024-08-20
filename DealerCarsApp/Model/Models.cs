namespace DealerCarsApp.Model
{
    public class Models: BaseEntity
    {
        public string ModelName { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public ICollection<Trim> Trim { get; set; }
    }
}

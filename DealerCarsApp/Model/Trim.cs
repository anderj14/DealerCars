namespace DealerCarsApp.Model
{
    public class Trim : BaseEntity
    {
        public string TrimName { get; set; }
        public int ModelsId { get; set; }
        public Models Models { get; set; }

    }
}

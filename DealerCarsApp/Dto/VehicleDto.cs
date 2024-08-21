namespace DealerCarsApp.Dto
{
    public class VehicleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public string Owner { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public int Mileage { get; set; }
        public string VIN { get; set; }
        public double FuelEfficiency { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string ExteriorFeatures { get; set; }
        public string InteriorFeatures { get; set; }

        public bool HasABS { get; set; }
        public bool HasAirbags { get; set; }
        public bool HasStabilityControl { get; set; }
        public bool HasTractionControl { get; set; }
        public bool HasRearviewCamera { get; set; }
        public bool HasBlindSpotMonitoring { get; set; }
        public bool HasLaneDepartureWarning { get; set; }
        public bool HasAutomaticEmergencyBraking { get; set; }

        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string StatusName { get; set; }
        public string BodyStyleName { get; set; }
        public string EngineName { get; set; }
        public string DriveTrainName { get; set; }
        public string FuelName { get; set; }
    }
}

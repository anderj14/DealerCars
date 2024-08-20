namespace DealerCarsApp.Model
{
    public class Vehicle : BaseEntity
    {
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

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int ModelsId { get; set; }
        public Models Models { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        public int BodyStyleId { get; set; }
        public BodyStyle BodyStyle { get; set; }

        public int EngineId { get; set; }
        public Engine Engine { get; set; }

        public int DriveTrainId { get; set; }
        public DriveTrain DriveTrain { get; set; }

        public int FuelId { get; set; }
        public Fuel Fuel { get; set; }
    }
}

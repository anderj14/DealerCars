using DealerCarsApp.Model;

namespace DealerCarsApp.Data
{
    public class SeedData
    {
        private readonly DataContext _context;

        public SeedData(DataContext context)
        {
            _context = context;
        }

        public void SeedDataContext()
        {
            if (!_context.VehicleBrands.Any())
            {
                var vehicleBrands = new List<VehicleBrand>()
                {
                    new VehicleBrand()
                    {
                        Vehicle = new Vehicle()
                        {
                            Name = "Toyota Corolla LE",
                            Year = 2011,
                            Price = 12000,
                            Mileage = 122000,
                            Status = new Status()
                            {
                                StatusName = "Used"
                            },
                            Engine = new Engine()
                            {
                                EngineType = "Gasoline"
                            },
                            BodyStyle = new BodyStyle()
                            {
                                BodyType = "Sedan"
                            },
                            DriveTrain = new DriveTrain()
                            {
                                DriveTrainType = "Automatic"
                            },
                            VehicleModels = new List<VehicleModel>()
                            {
                                new VehicleModel(){
                                    Model = new Models()
                                    {
                                        ModelName = "Corolla",
                                        Type = new Types()
                                        {
                                            TypeName = "LE"
                                        }
                                    }
                                }
                            },
                            VehicleFuelTypes = new List<VehicleFuelType>()
                            {
                                new VehicleFuelType()
                                {
                                    Fuel = new Fuel()
                                    {
                                        FuelType = "Gas"
                                    }
                                }
                            }
                        },
                        Brand = new Brand()
                        {
                            BrandName = "Toyota"
                        }
                    }, // Second car
                    new VehicleBrand()
                    {
                        Vehicle = new Vehicle()
                        {
                            Name = "Honda Civic SI",
                            Year = 2015,
                            Price = 15000,
                            Mileage = 80000,
                            Status = new Status()
                            {
                                StatusName = "Used"
                            },
                            Engine = new Engine()
                            {
                                EngineType = "Gasoline"
                            },
                            BodyStyle = new BodyStyle()
                            {
                                BodyType = "Sedan"
                            },
                            DriveTrain = new DriveTrain()
                            {
                                DriveTrainType = "Mechanical"
                            },
                            VehicleModels = new List<VehicleModel>()
                            {
                                new VehicleModel(){
                                    Model = new Models()
                                    {
                                        ModelName = "Civic",
                                        Type = new Types()
                                        {
                                            TypeName = "SI"
                                        }
                                    }
                                }
                            },
                            VehicleFuelTypes = new List<VehicleFuelType>()
                            {
                                new VehicleFuelType()
                                {
                                    Fuel = new Fuel()
                                    {
                                        FuelType = "Gas"
                                    }
                                }
                            }
                        },
                        Brand = new Brand()
                        {
                            BrandName = "Honda"
                        }
                    }, //Thirth car
                    new VehicleBrand()
                    {
                        Vehicle = new Vehicle()
                        {
                            Name = "Honda Crv Touring",
                            Year = 2016,
                            Price = 25000,
                            Mileage = 64000,
                            Status = new Status()
                            {
                                StatusName = "Used"
                            },
                            Engine = new Engine()
                            {
                                EngineType = "Gasoline"
                            },
                            BodyStyle = new BodyStyle()
                            {
                                BodyType = "SUV"
                            },
                            DriveTrain = new DriveTrain()
                            {
                                DriveTrainType = "Automatic"
                            },
                            VehicleModels = new List<VehicleModel>()
                            {
                                new VehicleModel(){
                                    Model = new Models()
                                    {
                                        ModelName = "Crv",
                                        Type = new Types()
                                        {
                                            TypeName = "Touring"
                                        }
                                    }
                                }
                            },
                            VehicleFuelTypes = new List<VehicleFuelType>()
                            {
                                new VehicleFuelType()
                                {
                                    Fuel = new Fuel()
                                    {
                                        FuelType = "Gas"
                                    }
                                }
                            }
                        },
                        Brand = new Brand()
                        {
                            BrandName = "Honda"
                        }
                    }
                };
                _context.VehicleBrands.AddRange(vehicleBrands);
                _context.SaveChanges();
            }
        }
    }
}

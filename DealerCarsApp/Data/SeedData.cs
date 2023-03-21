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
            if (!_context.VehicleFuelTypes.Any())
            {
                var vehicleFuelTypes = new List<VehicleFuelType>()
                {
                    new VehicleFuelType()
                    {
                        Vehicle = new Vehicle()
                        {
                            Name = "Jeep Wrangler Unlimited Sport",
                            Year = 2020,
                            Price = 40000,
                            Mileage = 40000,
                            Status = new Status()
                            {
                                StatusName = "Crashed"
                            },
                            Engine = new Engine()
                            {
                                EngineType = "4 Cylinders"
                            },
                            BodyStyle = new BodyStyle()
                            {
                                BodyType = "Jeep"
                            },
                            DriveTrain = new DriveTrain()
                            {
                                DriveTrainType = "Mecanic or Automatic"
                            },
                            Brand = new Brand()
                            {
                                BrandName = "Jeep",
                                Models = new List<Models>()
                                {
                                    new Models()
                                    {
                                        ModelName = "Wrangler",
                                        Types = new List<Types>()
                                        {
                                            new Types()
                                            {
                                                TypeName = "Unlimited Sport"
                                            }
                                        }

                                    }
                                }
                            }
                        },
                        Fuel = new Fuel()
                        {
                            FuelType = "Gasoline",
                        },
                    }, 
                    // Second car
                    new VehicleFuelType()
                    {
                        Vehicle = new Vehicle()
                        {
                            Name = "Toyota Prado TX",
                            Year = 2015,
                            Price = 25000,
                            Mileage = 70000,
                            Status = new Status()
                            {
                                StatusName = "Used"
                            },
                            Engine = new Engine()
                            {
                                EngineType = "6 Cylinders"
                            },
                            BodyStyle = new BodyStyle()
                            {
                                BodyType = "Jeepeta"
                            },
                            DriveTrain = new DriveTrain()
                            {
                                DriveTrainType = "Automatica"
                            },
                            Brand = new Brand()
                            {
                                BrandName = "Toyota",
                                Models = new List<Models>()
                                {
                                    new Models()
                                    {
                                        ModelName = "Prado",
                                        Types = new List<Types>()
                                        {
                                            new Types()
                                            {
                                                TypeName = "TX"
                                            }
                                        }

                                    }
                                }
                            }
                        },
                        Fuel = new Fuel()
                        {
                            FuelType = "Deseil",
                        },

                    }, //Third car
                    new VehicleFuelType()
                    {
                        Vehicle = new Vehicle()
                        {
                            Name = "Hyundai Sonata LF",
                            Year = 2023,
                            Price = 30000,
                            Mileage = 0,
                            Status = new Status()
                            {
                                StatusName = "New"
                            },
                            Engine = new Engine()
                            {
                                EngineType = "5 Cylinders"
                            },
                            BodyStyle = new BodyStyle()
                            {
                                BodyType = "Sedan"
                            },
                            DriveTrain = new DriveTrain()
                            {
                                DriveTrainType = "Mecanic"
                            },
                            Brand = new Brand()
                            {
                                BrandName = "Hyundai",
                                Models = new List<Models>()
                                {
                                    new Models()
                                    {
                                        ModelName = "Sonata",
                                        Types = new List<Types>()
                                        {
                                            new Types()
                                            {
                                                TypeName = "LF"
                                            }
                                        }
                                    }
                                }
                            }
                        },
                        Fuel = new Fuel()
                        {
                            FuelType = "Gas GLP",
                        },
                        
                    }
                };
                _context.VehicleFuelTypes.AddRange(vehicleFuelTypes);
                _context.SaveChanges();
            }
        }
    }
}

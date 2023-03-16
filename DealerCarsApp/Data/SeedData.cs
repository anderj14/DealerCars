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
                            Name = "Jeep Wrangler Unlimited Sport",
                            Year = 2020,
                            Price = 40000,
                            Mileage = 40000,
                            Status = new Status()
                            {
                                StatusName = "Used"
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

                            VehicleFuelTypes = new List<VehicleFuelType>()
                            {
                                new VehicleFuelType()
                                {
                                    Fuel = new Fuel()
                                    {
                                        FuelType = "Gasoline"
                                    }
                                }
                            }
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
                    }, // Second car
                    new VehicleBrand()
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
                            VehicleFuelTypes = new List<VehicleFuelType>()
                            {
                                new VehicleFuelType()
                                {
                                    Fuel = new Fuel()
                                    {
                                        FuelType = "Deseil"
                                    }
                                }
                            }
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
                    }, //Third car
                    new VehicleBrand()
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
                            VehicleFuelTypes = new List<VehicleFuelType>()
                            {
                                new VehicleFuelType()
                                {
                                    Fuel = new Fuel()
                                    {
                                        FuelType = "Gas GLP"
                                    }
                                }
                            }
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
                    }
                };
                _context.VehicleBrands.AddRange(vehicleBrands);
                _context.SaveChanges();
            }
        }
    }
}

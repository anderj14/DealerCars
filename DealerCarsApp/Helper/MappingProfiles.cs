using AutoMapper;
using DealerCarsApp.Dto;
using DealerCarsApp.Model;

namespace DealerCarsApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Vehicle, VehicleDto>();
            CreateMap<Brand, BrandDto>();
            CreateMap<Fuel, FuelDto>();
            CreateMap<Models, ModelDto>();
            CreateMap<Types, TypesDto>();
            CreateMap<BodyStyle, BodyStyleDto>();
            CreateMap<DriveTrain, DriveTrainDto>();
            CreateMap<Engine, EngineDto>();
            CreateMap<Status, StatusDto>();
        }
    }
}

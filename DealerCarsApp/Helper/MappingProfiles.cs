using AutoMapper;
using DealerCarsApp.Dto;
using DealerCarsApp.Model;

namespace DealerCarsApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Vehicle, VehicleDto>()
            .ForMember(x => x.Brand, s => s.MapFrom(o => o.Brand.BrandName))
            .ForMember(x => x.Brand, s => s.MapFrom(o => o.Brand.BrandName))
            .ForMember(x => x.Brand, s => s.MapFrom(o => o.Brand.BrandName))
            .ForMember(x => x.Brand, s => s.MapFrom(o => o.Brand.BrandName))
            .ForMember(x => x.Brand, s => s.MapFrom(o => o.Brand.BrandName))
            .ForMember(x => x.Brand, s => s.MapFrom(o => o.Brand.BrandName))
            .ForMember(x => x.Brand, s => s.MapFrom(o => o.Brand.BrandName));
            CreateMap<Brand, BrandDto>();
            CreateMap<Fuel, FuelDto>();
            CreateMap<Models, ModelDto>();
            CreateMap<Trim, TrimDto>();
            CreateMap<BodyStyle, BodyStyleDto>();
            CreateMap<DriveTrain, DriveTrainDto>();
            CreateMap<Engine, EngineDto>();
            CreateMap<Status, StatusDto>();
        }
    }
}

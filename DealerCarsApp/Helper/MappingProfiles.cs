using AutoMapper;
using DealerCarsApp.CreateDto;
using DealerCarsApp.Dto;
using DealerCarsApp.Model;

namespace DealerCarsApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Vehicle, VehicleDto>()
            .ForMember(x => x.BrandName, s => s.MapFrom(o => o.Brand.BrandName))
            .ForMember(x => x.ModelName, s => s.MapFrom(o => o.Models.ModelName))
            .ForMember(x => x.StatusName, s => s.MapFrom(o => o.Status.StatusName))
            .ForMember(x => x.BodyStyleName, s => s.MapFrom(o => o.BodyStyle.BodyTypeName))
            .ForMember(x => x.EngineName, s => s.MapFrom(o => o.Engine.EngineTypeName))
            .ForMember(x => x.DriveTrainName, s => s.MapFrom(o => o.DriveTrain.DriveTrainName))
            .ForMember(x => x.FuelName, s => s.MapFrom(o => o.Fuel.FuelName));
            CreateMap<Brand, BrandDto>();
            CreateMap<Fuel, FuelDto>();
            CreateMap<Models, ModelDto>();
            CreateMap<Trim, TrimDto>();
            CreateMap<BodyStyle, BodyStyleDto>();
            CreateMap<DriveTrain, DriveTrainDto>();
            CreateMap<Engine, EngineDto>();
            CreateMap<Status, StatusDto>();

            CreateMap<CreateVehicle, Vehicle>();
            CreateMap<CreateTrimDto, Trim>();
            CreateMap<CreateStatusDto, Status>();
            CreateMap<CreateModelsDto, Models>();
            CreateMap<CreateFuelDto, Fuel>();
            CreateMap<CreateEngineDto, Engine>();
            CreateMap<CreateDriveTrainDto, DriveTrain>();
            CreateMap<CreateBrandDto, Brand>();
            CreateMap<CreateBodyStyleDto, BodyStyle>();
        }
    }
}

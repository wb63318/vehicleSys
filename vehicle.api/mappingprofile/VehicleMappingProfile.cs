using AutoMapper;
using vehicle.api.models.domain;
using vehicle.api.models.dtos;
using vehicle.api.models.requests;

namespace vehicle.api.mappingprofile
{
    public class VehicleMappingProfile : Profile
    {
        public VehicleMappingProfile()
        {
            CreateMap<FuelType ,FuelTypeDto>().ReverseMap();
            CreateMap<VehicleMake ,VehicleMakeDto>().ReverseMap();
            CreateMap<VehicleMake, VehicleMakeDto>().ReverseMap();
            CreateMap<VehicleSize ,VehicleSizeDto>().ReverseMap();
            CreateMap<VehicleType ,VehicleTypeDto>().ReverseMap();
            CreateMap<VehicleMake ,AddVehicleMake>().ReverseMap();
            CreateMap<VehicleMake, UpdateVehicleMake>().ReverseMap();
            CreateMap<VehicleModel ,AddVehicleModel>().ReverseMap();
            CreateMap<VehicleModel ,UpdateVehicleModel>().ReverseMap();
        }
    }
}

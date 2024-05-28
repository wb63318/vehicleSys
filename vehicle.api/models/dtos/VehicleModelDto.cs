using vehicle.api.models.domain;
using vehicle.api.models.enums;

namespace vehicle.api.models.dtos
{
    public class VehicleModelDto
    {
        public long Id { get; set; }
        public long VehicleMakeId { get; set; }
        public string modelName { get; set; }
        public string ManufactureYear { get; set; }
        public int VehicletypeId { get; set; }
        public int VehicleSizeId { get; set; }
        public decimal? Price { get; set; }
        public DriveWheels Wheels { get; set; }
        public Vehiclecategory Vehiclecategory { get; set; }

        // nav prop 
        public VehicleMakeDto Make { get; set; }
        public VehicleTypeDto VehicleType { get; set; }
        public VehicleSizeDto VehicleSize { get; set; }
        public List<FuelTypeDto> FuelTypes { get; set; }
    }
}

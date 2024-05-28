using vehicle.api.models.domain;

namespace vehicle.api.models.dtos
{
    public class VehicleSizeDto
    {
        public int Id { get; set; }
        public string vehicleSize { get; set; }

        // + add nav prop
        public VehicleModelDto Vehicle { get; set; }
    }
}

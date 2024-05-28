using vehicle.api.models.domain;

namespace vehicle.api.models.dtos
{
    public class VehicleTypeDto
    {
        public int Id { get; set; }
        public string vehicletype { get; set; }

        // + add nav prop
        public VehicleModelDto Vehicle { get; set; }
    }
}

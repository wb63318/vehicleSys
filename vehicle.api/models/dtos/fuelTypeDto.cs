
namespace vehicle.api.models.dtos
{
    public class FuelTypeDto
    {
        public int Id { get; set; }
        public string Fueltype { get; set; }

        // + add nav prop
        public VehicleModelDto Vehicle { get; set; }
    }
}

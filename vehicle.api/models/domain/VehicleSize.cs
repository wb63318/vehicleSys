namespace vehicle.api.models.domain
{
    public class VehicleSize
    {
        public int Id { get; set; }
        public string vehicleSize { get; set; }

        // + add nav prop
        public VehicleModel Vehicle { get; set; }
    }
}

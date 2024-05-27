namespace vehicle.api.models.domain
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string vehicletype { get; set; }

        // + add nav prop
        public VehicleModel Vehicle { get; set; }
    }
}

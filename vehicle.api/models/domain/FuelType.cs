namespace vehicle.api.models.domain
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Fueltype { get; set; }

        // + add nav prop
        public VehicleModel Vehicle { get; set; }
    }
}

namespace vehicle.api.models.domain
{
    public class VehicleMake
    {
        public long Id { get; set; }
        public string makeName { get; set; }
        public string Country { get; set; }

        public List<VehicleModel> Models { get; set; }
    }
}

namespace vehicle.api.models.domain
{
    public class VehicleMake
    {
        public long Id { get; set; }
        public string makeName { get; set; }
        public string CountryofOrigin { get; set; }

        public List<VehicleModel> Models { get; set; }
    }
}

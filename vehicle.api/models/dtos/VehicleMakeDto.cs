
namespace vehicle.api.models.dtos
{
    public class VehicleMakeDto
    {
        public long Id { get; set; }
        public string makeName { get; set; }
        public string CountryofOrigin { get; set; }

        public List<VehicleModelDto> Models { get; set; }
    }
}

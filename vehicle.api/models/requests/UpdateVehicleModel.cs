using vehicle.api.models.enums;

namespace vehicle.api.models.requests
{
    public class UpdateVehicleModel
    {
        public long VehicleMakeId { get; set; }
        public string modelName { get; set; }
        public string ManufactureYear { get; set; }
        public int VehicletypeId { get; set; }
        public int VehicleSizeId { get; set; }
        public decimal? Price { get; set; }
        public DriveWheels Wheels { get; set; }
        public Vehiclecategory Vehiclecategory { get; set; }
    }
}

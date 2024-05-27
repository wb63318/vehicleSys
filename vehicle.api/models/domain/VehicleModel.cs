namespace vehicle.api.models.domain
{
    public class VehicleModel
    {
        public long Id { get; set; }
        public long VehicleMakeId { get; set; }
        public string modelName { get; set; }
        public string ManufactureYear { get; set; }

        // nav prop 
        public VehicleMake Make { get; set; }

    }
}

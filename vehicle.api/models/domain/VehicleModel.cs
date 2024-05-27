namespace vehicle.api.models.domain
{
    public class VehicleModel
    {
        public long Id { get; set; }
        public long VehicleMakeId { get; set; }
        public string modelName { get; set; }
        public string ManufactureYear { get; set; }
        public int VehicletypeId { get; set; }
        public int VehicleSizeId { get; set; }
        public decimal? Price { get; set; }

        // nav prop 
        public VehicleMake Make { get; set; }
        public VehicleType VehicleType { get; set; }
        public VehicleSize VehicleSize { get; set; }
        public List<FuelType> FuelTypes { get; set; }

    }
}

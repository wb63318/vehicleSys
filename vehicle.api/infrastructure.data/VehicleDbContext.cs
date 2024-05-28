using Microsoft.EntityFrameworkCore;
using vehicle.api.models.domain;

namespace vehicle.api.infrastructure.data
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<VehicleMake> VehicleMakes { get; set;}
        public DbSet<VehicleModel> VehicleModels { get; set;}
        public DbSet<VehicleSize> VehicleSizes { get; set;}
        public DbSet<VehicleType> VehicleTypes { get; set;}
    }
}

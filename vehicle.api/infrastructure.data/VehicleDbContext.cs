using Microsoft.EntityFrameworkCore;

namespace vehicle.api.infrastructure.data
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}

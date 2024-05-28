using vehicle.api.infrastructure.data;
using vehicle.api.models.domain;

namespace vehicle.api.services.repo
{
    public class VehicleMakeService : IVehicleMakeService
    {
        private readonly VehicleDbContext _vehicleDb;

        public VehicleMakeService(VehicleDbContext vehicleDb)
        {
            this._vehicleDb = vehicleDb;
        }

        public Task<VehicleMake> CreateAsync(VehicleMake make)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleMake> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleMake> GetVehicleMakeByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VehicleMake>> GetVehicleMakeListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<VehicleMake> UpdateAsync(long id, VehicleMake make)
        {
            throw new NotImplementedException();
        }
    }
}

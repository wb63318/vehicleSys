using vehicle.api.infrastructure.data;
using vehicle.api.models.domain;

namespace vehicle.api.services.repo
{
    public class VehicleModelService : IVehicleModelService
    {
        private readonly VehicleDbContext _vehicleDb;

        public VehicleModelService(VehicleDbContext vehicleDb)
        {
            this._vehicleDb = vehicleDb;
        }

        public Task<VehicleModel> CreateAsync(VehicleModel model)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleModel> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleModel> GetVehicleMakeByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VehicleModel>> GetVehicleMakeListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<VehicleModel> UpdateAsync(long id, VehicleModel model)
        {
            throw new NotImplementedException();
        }
    }
}

using vehicle.api.models.domain;

namespace vehicle.api.services.repo
{
    public interface IVehicleModelService
    {
        Task<List<VehicleModel>> GetVehicleMakeListAsync();
        Task<VehicleModel> GetVehicleMakeByIdAsync(long id);
        Task<VehicleModel> CreateAsync(VehicleModel model);
        Task<VehicleModel> UpdateAsync(long id, VehicleModel model);
        Task<VehicleModel> DeleteAsync(long id);
    }
}

using vehicle.api.models.domain;

namespace vehicle.api.services.repo
{
    public interface IVehicleMakeService
    {
        Task<List<VehicleMake>> GetVehicleMakeListAsync();
        Task<VehicleMake> GetVehicleMakeByIdAsync(long id);
        Task<VehicleMake> CreateAsync(VehicleMake make);
        Task<VehicleMake> UpdateAsync(long id, VehicleMake make);
        Task <VehicleMake> DeleteAsync(long id);
    }
}

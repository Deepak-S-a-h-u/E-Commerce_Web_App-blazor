
using Application.Common.Models;
using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetVehicle();
        Task<List<Vehicle>> GetVehicleByItsType(BrandClassification brand );
        Task<Vehicle> AddVehicle(Vehicle car);
        Task<Vehicle> GetVehicleByIdAsync(int id);
        Task<Vehicle> UpdateVehicle(Vehicle car);
        Task<Vehicle> DeleteVehicle(int CarId);
        Task saveChanges();
        public Task PostMultiFileAsync(VehiclesDto vehiclesDto);
    }
}

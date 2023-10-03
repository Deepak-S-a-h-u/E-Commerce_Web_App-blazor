using Application.Common.Models;
using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface ICarRepository
    {
        Task<IEnumerable<CarDto>> GetCars();
        Task<Car> GetCarById(int carId);
        Task<CarDto> AddCar(CarDto car);
        Task<Car> UpdateCar(Car car);
        Task<Car> DeleteCar(int CarId);
        Task saveChanges();
      
    }
}

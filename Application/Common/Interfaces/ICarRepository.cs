using Application.Common.Models;
using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetCars();
        Task<Car> GetCarById(int carId);
        Task<Car> AddCar(Car car);
        Task<Car> UpdateCar(Car car);
        Task<Car> DeleteCar(int CarId);
        Task saveChanges();
      
    }
}

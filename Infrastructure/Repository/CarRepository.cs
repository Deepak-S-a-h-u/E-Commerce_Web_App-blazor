
using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<CarRepository> _logger; // Logger instance
        private readonly IMapper _mapper;

        public CarRepository(ApplicationDbContext applicationDbContext, ILogger<CarRepository> logger,IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// This method is used to add a new Car in the database.
        /// </summary>
        /// <param name="Car">Object containing values</param>
        /// <returns>The added Car</returns>



        
        public async Task<CarDto> AddCar(CarDto car)
        {
             var data= _mapper.Map<Car>(car);   
            var result = await _applicationDbContext.Cars.AddAsync(data);
            await saveChanges();

            _logger.LogInformation("New Car added to the database."); // Log information

            return car;
        }

        /// <summary>
        /// This method is used to delete an Car from the database.
        /// </summary>
        /// <param name="id">The ID of the Car to be deleted</param>
        /// <returns>The deleted Car</returns>
        public async Task<Car> DeleteCar(int id)
        {
            var result = await _applicationDbContext.Cars.FirstOrDefaultAsync(e => e.Id == id);
            var results = _applicationDbContext.Cars.Remove(result);
            _logger.LogInformation("Deleted an Car");
            await saveChanges();
            return results.Entity;
        }

        /// <summary>
        /// This method is used to get an Car by its ID from the database.
        /// </summary>
        /// <param name="CarId">The ID of the Car to retrieve</param>
        /// <returns>The retrieved Car</returns>
        public async Task<Car> GetCarById(int CarId)
        {
            var data = await _applicationDbContext.Cars.FirstOrDefaultAsync(a => a.Id == CarId);
            _logger.LogInformation("Retrieved an Car by ID");

            return data;
        }


        /// <summary>
        /// This method is used to get all Cars from the database.
        /// </summary>
        /// <returns>A list of all Cars</returns>
        public async Task<IEnumerable<CarDto>> GetCars()
        {
            _logger.LogInformation("GetCars called to Get all Cars from database");

            return _mapper.Map<List<CarDto>>(_applicationDbContext.Cars.ToList());
            
        }


        /// <summary>
        /// This method is used to save changes made to the database.
        /// </summary>
        public async Task saveChanges()
        {
            await _applicationDbContext.SaveChangesAsync();
            _logger.LogInformation("Saved changes to the database");
        }

        /// <summary>
        /// This method is used to update an existing Car in the database.
        /// </summary>
        /// <param name="Car">The updated Car object</param>
        /// <returns>The updated Car</returns>
        public async Task<Car> UpdateCar(Car Car)
        {
          
            var result = await _applicationDbContext.Cars.FirstOrDefaultAsync(e => e.Id == Car.Id);
            if (result == null)
            {
                return null;
            }
            /*result.CarDate = Car.CarDate;
            result.ClientName = Car.ClientName;
            result.PickupAddress = Car.PickupAddress;
            result.DeliveryAddress = Car.DeliveryAddress;
            result.ClientRef = Car.ClientRef;
            result.BillingRef = Car.BillingRef;*/

            // Logging
            _logger.LogInformation("Updating an existing Car");

           /* IEnumerable<Address> existingProducts = result.Address;
            foreach (var item in existingProducts)
            {
                item.Car = null;
            }

            if (existingProducts == null) { return null; }
            if (existingProducts.Count() > 0)
            {
                foreach (var product in existingProducts)
                {
                    _applicationDbContext.Product.Remove(product);
                    await saveChanges();
                }
            }

            foreach (var product in Car.Products)
            {
                _applicationDbContext.Product.Add(product);
                await saveChanges();
            }*/

            return result;
        }

       
    }
}

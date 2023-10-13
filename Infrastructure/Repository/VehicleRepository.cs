
using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System.Collections;
using System.Text.Json.Serialization;

namespace Infrastructure.Repository
{
}public class VehicleRepository :IVehicleRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    private readonly ILogger<VehicleRepository> _logger; // Logger instance
    private readonly IMapper _mapper;
    
            public VehicleRepository(ApplicationDbContext applicationDbContext, ILogger<VehicleRepository> logger,IMapper mapper)
            {
                _applicationDbContext = applicationDbContext;
                _logger = logger;
                _mapper = mapper;
            }

            




            public async Task<Vehicle> AddVehicle(Vehicle vehicle)
            {
                    
                var result = await _applicationDbContext.Vehicles.AddAsync(vehicle);
                await saveChanges();

                _logger.LogInformation("New Car added to the database."); // Log information

                return vehicle;
            }

            public async Task<Vehicle> DeleteVehicle(int id)
            {
                var result = await _applicationDbContext.Vehicles.FirstOrDefaultAsync(e => e.Id == id);
                var results = _applicationDbContext.Vehicles.Remove(result);
                _logger.LogInformation("Deleted an Car");
                await saveChanges();
                return results.Entity;
            }

    public async Task<Vehicle> GeVehicleById(int carId)
    {
        var data = _applicationDbContext.Vehicles.Where(a => a.Id == carId);
        if (data != null) return (Vehicle)data;
        return null;
    }

    public async Task<List<Vehicle>> GetVehicleByItsType(BrandClassification classification)

            {
                   
                var data = await _applicationDbContext.Vehicles.Include(u=>u.Brand).Where(u => u.Brand.Classification == classification).ToListAsync();
                _logger.LogInformation("Retrieved an Car by ID");
                return data;
            }


            //public async Task<IEnumerable<Vehicle>> GetVehicle()
            //{
            //    _logger.LogInformation("GetCars called to Get all Cars from database");

        
            //        var result = _applicationDbContext.Vehicles.Include(u=> u.Brand).ToListAsync();
                       

                     
            //}


        
            public async Task saveChanges()
            {
                await _applicationDbContext.SaveChangesAsync();
                _logger.LogInformation("Saved changes to the database");
            }

    public Task<Vehicle> UpdateVehicle(Vehicle car)
    {
        throw new NotImplementedException();
    }




    public async Task PostMultiFileAsync(VehiclesDto vehiclesDto)
    {
        try
        {
            var result = _mapper.Map<Vehicle>(vehiclesDto);

            //List<byte[]> resultsOfImages = new List<byte[]>();  
            List<byte[]> resultsOfImages = new List<byte[]>();
            foreach (var file in vehiclesDto.FileDetails)
            {                           
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    // fileDetails.FileData = stream.ToArray();
                  //  byte[] byteArray =  stream.ToArray();
                    resultsOfImages.Add(stream.ToArray());
                   // String str = new String(byteArray, "UTF-8");

                    //result.FileData = fileDetails.FileData;
                }
                // Now, you have the file data in the Vehicle entity.
                // You can set other properties of the Vehicle entity here as well
            }
            
           
            result.FileData = JsonConvert.SerializeObject(resultsOfImages);
       //     var done = JsonConvert.DeserializeObject(result.FileData);
            _applicationDbContext.Vehicles.Add(result);


            await _applicationDbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public Task<IEnumerable<Vehicle>> GetVehicle()
    {
        throw new NotImplementedException();
    }

    public async Task<Vehicle> GetVehicleByIdAsync(int id)
    {
        var data = _applicationDbContext.Vehicles.Where(a => a.Id == id).FirstOrDefault();
        if (data != null) return data;
        return null;
    }
}

using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using Domain.Enums;
using FluentValidation.Internal;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.IO.Compression;
using System.Runtime.ExceptionServices;
using BrandClassification = Domain.Entities.BrandClassification;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _repository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public VehicleController(IVehicleRepository repository,IWebHostEnvironment webHostEnvironment)
        {
                _repository = repository;
              _webHostEnvironment = webHostEnvironment;
        }


        /*[HttpGet("image/{id}")]
        public async Task<IEnumerable<FileContentResult>> GetVehicleImages(int id)
        {
            var vehicle = await _repository.GetVehicleByIdAsync(id);

            if (vehicle == null || vehicle.FileData == null)
            {
                return new List<FileContentResult>(); // Return an empty list if the vehicle or image data is not found.
            }

            List<byte[]> imageList = JsonConvert.DeserializeObject<List<byte[]>>(vehicle.FileData);

            List<FileContentResult> fileResults = imageList.Select(imageData =>
                new FileContentResult(imageData, "image/jpeg")
            ).ToList();

            return fileResults;
        }*/




        [HttpGet("image/{id}")]
        public async Task<FileContentResult> GetVehicleImage( int id)
        {
            var vehicle = await _repository.GetVehicleByIdAsync(id);

            if (vehicle == null || vehicle.FileData == null)
            {
                return File(new byte[0], "image/jpeg"); // Return an empty image if the vehicle or image data is not found.
            }
            //return File(new byte[0], "image/jpeg");
            List<byte[]> data = JsonConvert.DeserializeObject<List<byte[]>>(vehicle.FileData);

            return File(data.FirstOrDefault() ,  "image/jpeg"); // Assuming the image format is JPEG
        }






        /*[HttpGet("image/{id}")]
        public async Task<FileContentResult> GetVehicleImage(int id)
        {
            var vehicle = await _repository.GetVehicleByIdAsync(id);
            //byte[] imageData = vehicle.FileData;
           List<Byte> images = new List<Byte>();
         foreach(var item in vehicle.FileData)
            {
                images.Add(item);
            }
            
            return  File(images.ToArray(), "image/jpeg"); // Assuming the image format is JPEG
        }*/


        /*[HttpGet]
        public async Task<IEnumerable<Vehicle>> GetAllCars () 
        {

            var vehicles = await _repository.GetVehicle();

            // Map the vehicles to a DTO
            var vehicleDtos = vehicles.Select(v => new testVM
            {
                Id = v.Id,
                ImageUrl = Url.Link("GetVehicleImage", new { id = v.Id });  
            });

            return vehicleDtos;
        }*/





        [HttpGet("GetVehicleByItsType")]
        public async Task<IEnumerable<Vehicle>> GetVehicleByItsType(BrandClassification brandClassification)
        {
         
            var vehicleData = await _repository.GetVehicleByItsType(brandClassification);
            return vehicleData;
        }


        [HttpPost("Addcar")]

        public async  Task<VehiclesDto> AddCar([FromForm] VehiclesDto vehicleDto)
        {
              await  _repository.PostMultiFileAsync(vehicleDto);

            return vehicleDto;
        }
    }

    /*[HttpPost("AddCar")]
    public async Task<Vehicle> AddCar([FromForm] Vehicle vehicle)
    {
        if (vehicle.Images != null)
        {
            string folder = "ProductsImages/images/";

               vehicle.ImageUrl=   await uploadImage(folder , vehicle.Images);
           *//* folder += Guid.NewGuid().ToString() + "_" + vehicle.Images.FileName ;
            string serverfolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

            await vehicle.Images.CopyToAsync(new FileStream(serverfolder, FileMode.Create));*//*
        }

        if (vehicle.GalleryFiles != null)
        {
            string folder = "ProductsImages/Gallery/";

            foreach(var files in vehicle.GalleryFiles)
            {

            }
            folder += Guid.NewGuid().ToString() + "_" + vehicle.Images.FileName;
            string serverfolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

            await vehicle.Images.CopyToAsync(new FileStream(serverfolder, FileMode.Create));
        }



        var vehicleCreation = await _repository.AddVehicle(vehicle);
        return vehicleCreation;
    }*/




    /*private async Task<string> uploadImage( string folderPath ,IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverfolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverfolder ,FileMode.Create));

            return "/" + folderPath;
        }*/
    }




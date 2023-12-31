﻿using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _repository;
        public CarController(ICarRepository repository)
        {
                _repository = repository;
        }


        [HttpGet]
        public async Task<IEnumerable<CarDto>> GetAllCars () 
        {
             var cars=await _repository.GetCars();
            return cars;
        }
        [HttpPost]
        public async Task<CarDto> AddCar(CarDto carDto )
        {
            var cars = await _repository.AddCar(carDto);
            return cars;
        }
    }
}

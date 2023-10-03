using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : Controller
    {
        private readonly IMobileRepository _repository;
        public MobileController(IMobileRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IEnumerable<MobileDto>> GetAllCars()
        {
            var mobile = await _repository.GetmobileDetails();
            return mobile;
        }

        [HttpPost]
        public async Task<MobileDto> AddCar(MobileDto carDto)
        {
            
            var mobile = await _repository.AddMobile(carDto);
            return mobile;
        }
    }

   }

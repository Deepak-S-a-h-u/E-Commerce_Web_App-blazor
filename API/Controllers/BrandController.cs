using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;


        public BrandController( IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        [HttpGet]

        public async Task<IActionResult> Get(BrandClassification brand)
        {
            var result = await _brandRepository.GetBrand(brand);
            return Ok(result);

        }

        [HttpPost]
        public async Task<IActionResult> AddBrand(Brand brand)
        {
            var result =  await _brandRepository.CreateBrand(brand);
            return Ok(result);
        }



        [HttpGet("GetAll")]
    
        public async Task<IActionResult> GetAll()
        {
            var result = await _brandRepository.GetAll();
            return Ok(result);
        }
    }
}

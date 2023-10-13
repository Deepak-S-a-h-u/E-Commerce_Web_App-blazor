using Application.Common.Interfaces;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilterController : ControllerBase
    { 

        private readonly IFilterRepository _filterRepository;

        private readonly IGenericRepository<object> _repository;

        public FilterController(IFilterRepository filterRepository, IGenericRepository<object> repository)
        {
            _filterRepository = filterRepository;
            _repository = repository;
        }

        /* [HttpGet]
         public async Task <IActionResult> FilterPrice(int uptoPrice)
         { 
                var data = await _filterRepository.FilterPrice(uptoPrice);*//*
                var data = _filterRepository.FilterByPrice<>()
             return Ok(data);
         }*/

        [HttpGet("filter")]
        public IActionResult FilterEntities(string tableName,int uptoPrice)
        {
            var filteredEntities = _repository.FilterByPrice(tableName, uptoPrice);

            if (filteredEntities == null)
            {
                return NotFound("Table with name {tableName} not found.");
            }

            return Ok(filteredEntities);
        }
    }



}


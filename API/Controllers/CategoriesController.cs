using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
                             
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
       private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesController(ICategoriesRepository categoriesRepository ) 
        { 
              _categoriesRepository = categoriesRepository;
        }

        [HttpGet]
        [Route("GetAllCategories")]
        public async Task<Categories> GetAllCategories()
        {
           var data = await _categoriesRepository.GetAllCategories();
            return data;
        }
    }
}


using Application.Common.Models;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mappings
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            
            CreateMap<CarDto, Car>();
            CreateMap<Car, CarDto>();
           
        }
    }
}

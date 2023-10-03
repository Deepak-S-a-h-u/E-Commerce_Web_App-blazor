
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mappings
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            
            CreateMap<Car, CarDto>().ReverseMap();

            CreateMap<Mobile, MobileDto>().ReverseMap();

           
        }
    }
}

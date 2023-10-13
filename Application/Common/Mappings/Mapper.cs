
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mappings
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Vehicle, VehiclesDto>().ReverseMap();


            CreateMap<Car, CarDto>().ReverseMap();

            CreateMap<Mobile, MobileDto>().ReverseMap();

            CreateMap<Electronics, ElectronicsDto>().ReverseMap();  


           
        }
    }
}

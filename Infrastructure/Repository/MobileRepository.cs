using Application.Common.Interfaces;
using Application.Common.Mappings;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
   /* public class MobileRepository : IMobileRepository
    {


        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<MobileRepository> _logger; // Logger instance
        private readonly IMapper _mapper;

        public MobileRepository(ApplicationDbContext applicationDbContext, ILogger<MobileRepository> logger, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<MobileDto> AddMobile(MobileDto mobile)
        {
            var data= _mapper.Map<Mobile>(mobile);
            var result = await _applicationDbContext.Mobiles.AddAsync(data);
            await saveChanges();

            _logger.LogInformation("New Mobile added to the database."); // Log information

            return mobile;
        }

        public Task<MobileDto> DeleteMobile(int mobileid)
        {
            throw new NotImplementedException();
        }

        public Task<MobileDto> GetMobileById(int mobileid)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MobileDto>> GetmobileDetails()
        {
            _logger.LogInformation("GetMobile called to Get all Mobile from database");

            return _mapper.Map<List<MobileDto>>(_applicationDbContext.Mobiles.ToList());
           
        }

        public async Task saveChanges()
        {
            await _applicationDbContext.SaveChangesAsync();
            _logger.LogInformation("Saved changes to the database");
        }

        public Task<MobileDto> UpdateMobile(MobileDto mobile)
        {
            throw new NotImplementedException();
        }
    }*/
}

using Application.Common.Interfaces;
using Application.Common.Models;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ElectronicRepository 
    {
        private readonly ApplicationDbContext _context;
       

        public ElectronicRepository(ApplicationDbContext context, IElectronicRepository repository)
        {
            _context = context;
           
        }

        public Task<ElectronicsDto> Add()
        {
            throw new NotImplementedException();
        }

       /* public Task<ElectronicsDto> GetAll()
        {
       
        }*/
    }
}

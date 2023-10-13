using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _context;
      
        public BrandRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Brand> CreateBrand(Brand brand)
        {
            await _context.Brand.AddAsync(brand);
            _context.SaveChanges();
            return brand;
        }

        public async Task<IEnumerable<Brand>> GetAll()
        {
          var result =  await _context.Brand.ToListAsync();
            return result;  
        }

        public async Task<List<Brand>> GetBrand(BrandClassification brandClassification)
        {
            var res = await _context.Brand.Where(u => u.Classification == brandClassification).ToListAsync();
            return res ;
        }

        
    
    }
}

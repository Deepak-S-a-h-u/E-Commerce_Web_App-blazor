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
   /* public class CategoriesRepository : ICategoriesRepository
    {
       *//* private readonly ApplicationDbContext _context;
        public CategoriesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

      

        public async Task<Categories> GetAllCategories()
        {
            Categories categories = new Categories()
            {
                Car = await _context.Cars.ToListAsync(),
                Mobile = await _context.Mobiles.ToListAsync()
            };
            return categories;
        }*//*
    }*/
}

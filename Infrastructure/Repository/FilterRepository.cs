using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class FilterRepository: IFilterRepository
    {
        private readonly ApplicationDbContext _context;
        

        public FilterRepository(ApplicationDbContext context)
        {
            _context = context;
        }

       /* public IEnumerable<FilterPrice> FilterByPrice(FilterPrice filterprice)
        {
            switch (filterprice.Categories)
            {
                case "Vehicle":
                    IEnumerable<Vehicle> vehicle;
                    vehicle =  _context.Vehicles.Where(s => s.Price > 0 && s.Price < filterprice.price).Include(u => u.Brand).ToList();
                    return (IEnumerable<T>)vehicle;
                case "Car":
                    return null;
                default:
                    return null;
            }
        }
*/
        public async Task<ICollection<Vehicle>> FilterPrice(int uptoPrice)
        {
            var filterPriceVehicle = await _context.Vehicles.Where(s => s.Price > 0 && s.Price < uptoPrice).Include(u => u.Brand).ToListAsync();
            return filterPriceVehicle;
        }
    }
}

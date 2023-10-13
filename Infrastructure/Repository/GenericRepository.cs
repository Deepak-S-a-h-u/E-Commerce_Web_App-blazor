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
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<T> FilterByPrice(string tableName, int uptoPrice)
        {
             
            switch (tableName) { 
         
            case "Vehicle":
          
                    return (IEnumerable<T>) _context.Vehicles.Where(s  => s.Price >0 && s.Price < uptoPrice).Include(u=> u.Brand).ToList();

                case "Mobile":

                 return(IEnumerable<T>)_context.Set<T>().OfType<Mobile>().Where(s => s.Price > 0 && s.Price < uptoPrice).Include(u => u.MobileBrand).ToList();

                /*case "Furniture":
                    return _context.Set<T>().OfType<Furniture>().Where(s => s.Price > 0 && s.Price < uptoPrice).Include(u => u.Brand).ToList();*/

                // Add more cases for other entity types as needed.
                default:
                return null;
            }

        }
    }
}

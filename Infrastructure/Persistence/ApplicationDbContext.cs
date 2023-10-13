using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext:DbContext
    {
        protected readonly IConfiguration _configuration;
        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Brand> Brand { get; set; }


        //   public DbSet<Mobile> Mobiles { get; set; }  

        //   public DbSet<Electronics> Electronics { get; set; }

        //   public DbSet<Furniture> Furnitures { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("PostgreSQL")).UseSnakeCaseNamingConvention();
        }
    }
}

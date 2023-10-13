using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IBrandRepository
    {
        public Task<List<Brand>> GetBrand(BrandClassification brandClassification);

        public Task<Brand> CreateBrand(Brand brand);

        public Task<IEnumerable<Brand>> GetAll();
    }
}

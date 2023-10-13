using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IFilterRepository
    {
        // IEnumerable<FilterPrice<INullable>> FilterModel(FilterPrice filterprice);
        Task<ICollection<Vehicle>> FilterPrice(int uptoPrice);
    }
}



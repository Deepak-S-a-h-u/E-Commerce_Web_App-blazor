using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Categories
    {
        public List<Car>? Car { get; set; }

        public List<Mobile> Mobile { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FilterPrice
    {
        public string Categories {  get; set; }

        public int price { get; set; }
    }
}

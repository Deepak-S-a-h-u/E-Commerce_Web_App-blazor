using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductBase
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public  string Description { get; set; }
        [Required]
        public string[]? Images { get; set; }
        [Required]
        public int Price { get; set; }

    }
}

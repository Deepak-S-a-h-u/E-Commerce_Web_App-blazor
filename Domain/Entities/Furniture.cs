using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Furniture:ProductBase
    {
        public Furniture_Types Furniture_Types { get; set; }
        public string SellerName { get; set; }
        public string SellerMobile { get; set; }
        [Key]
        public int Id { get; set; }
        public DateOnly ModelYear { get; set; }
        public int OwnerNo { get; set; }

        public int PinCode { get; set; }
    }
}

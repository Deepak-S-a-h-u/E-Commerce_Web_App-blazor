using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Mobile:ProductBase
    {
        public string SellerName { get; set; }
        public string SellerMobile { get; set; }
        [Key]
        public int Id { get; set; }
        public MobileBrand MobileBrand { get; set; }
        public DateOnly ModelYear { get; set; }
        public int OwnerNo { get; set; }

        public int PinCode { get; set; }

    }
}

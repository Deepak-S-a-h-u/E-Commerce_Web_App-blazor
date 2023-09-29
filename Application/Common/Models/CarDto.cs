using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class CarDto
    {
            public string SellerName { get; set; }
            public string SellerMobile { get; set; }
            
            public Brand Brand { get; set; }
            public DateOnly ModelYear { get; set; }
            public Fuel Fuel { get; set; }
            public Transmission Transmission { get; set; }
            public int DistanceDriven { get; set; }
            public int OwnerNo { get; set; }

            public int PinCode { get; set; }
        
    }

}


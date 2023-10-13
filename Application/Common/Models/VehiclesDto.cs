using Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class VehiclesDto
    {

        public string SellerName { get; set; }
        public string SellerMobile { get; set; }
   
        public DateOnly ModelYear { get; set; }
        public int DistanceDriven { get; set; }
        public int OwnerNo { get; set; }
        public int PinCode { get; set; }
        public int BrandId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<IFormFile>? FileDetails { get; set; }
       
        public int Price { get; set; }

    }
}

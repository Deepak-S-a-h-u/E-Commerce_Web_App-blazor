using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class ElectronicsDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string[]? Images { get; set; }
        public int Price { get; set; }
        public Electronics_Type ElectronicsType { get; set; }
        public string SellerName { get; set; }
        public string SellerMobile { get; set; }
        public DateOnly ModelYear { get; set; }
        public int OwnerNo { get; set; }
        public int PinCode { get; set; }
    }
}

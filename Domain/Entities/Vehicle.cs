using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Vehicle:ProductBase
    {
        //public TotalBrands MotorcyclesBrand { get; set; }

        public string SellerName { get; set; }
        public string SellerMobile { get; set; }
        [Key]
        public int Id { get; set; }
        public DateOnly ModelYear { get; set; }
        public int DistanceDriven { get; set; }
        public int OwnerNo { get; set; }
        public int PinCode { get; set; }
        public int BrandId { get; set; }
        [ForeignKey(nameof(BrandId))]
 
        public Brand? Brand { get; set; }
    }
    public enum BrandClassification
    {
        Scooter=1,
        MotorCycle=2,
        Cycle=3,
        Car=4
    }




}

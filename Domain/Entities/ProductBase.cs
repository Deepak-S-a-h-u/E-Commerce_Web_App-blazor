using Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
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
      
        public string FileData { get; set; }
        [Required]
        public int Price { get; set; }

        /* [Display(Name = "Choose the product photo to be display ")]

         [NotMapped]
         public IFormFile? Images { get; set; }

         public string ImageUrl { get; set; }


         public IFormCollection? GalleryFiles {get; set; }*/



    }
}

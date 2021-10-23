using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ProductModel
{
    public class ProductModelPostDTO
    {      

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string CatalogDescription { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Instructions { get; set; }
    }
}

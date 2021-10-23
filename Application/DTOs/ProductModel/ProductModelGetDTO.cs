using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.ProductModel
{
    public class ProductModelGetDTO
    {
        public int? ProductModelID { get; set; }

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
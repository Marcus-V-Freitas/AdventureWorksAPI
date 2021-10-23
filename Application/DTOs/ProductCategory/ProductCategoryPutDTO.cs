using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.ProductCategory
{
    public class ProductCategoryPutDTO
    {
        public int? ProductCategoryID { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
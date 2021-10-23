using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.ProductCategory
{
    public class ProductCategoryPostDTO
    {
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
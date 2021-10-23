using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.ProductCategory
{
    public class ProductCategoryGetDTO
    {
        public int? ProductCategoryID { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
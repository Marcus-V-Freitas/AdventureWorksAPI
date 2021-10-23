using Application.DTOs.ProductCategory;

namespace Application.DTOs.ProductSubCategory
{
    public class ProductSubCategoryGetDTO
    {
        public int? ProductSubcategoryID { get; set; }
        public int? ProductCategoryID { get; set; }
        public string Name { get; set; }

        public virtual ProductCategoryGetDTO ProductCategory { get; set; }
    }
}
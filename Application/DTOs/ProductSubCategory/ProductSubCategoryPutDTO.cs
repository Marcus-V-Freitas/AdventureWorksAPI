namespace Application.DTOs.ProductSubCategory
{
    public class ProductSubCategoryPutDTO
    {
        public int? ProductSubcategoryID { get; set; }
        public int? ProductCategoryID { get; set; }
        public string Name { get; set; }
    }
}
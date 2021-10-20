namespace Domain.Entities
{
    public class ProductSubCategory
    {
        public int ProductSubcategoryID { get; set; }
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}
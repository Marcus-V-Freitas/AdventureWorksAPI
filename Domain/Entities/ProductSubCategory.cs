namespace Domain.Entities
{
    public class ProductSubCategory
    {
        public int? ProductSubcategoryID { get; private set; }
        public int? ProductCategoryID { get; private set; }
        public string Name { get; private set; }

        public virtual ProductCategory ProductCategory { get; private set; }
    }
}
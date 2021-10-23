namespace Domain.Entities
{
    public class ProductModel
    {
        public int? ProductModelID { get; private set; }
        public string Name { get; private set; }
        public string CatalogDescription { get; private set; }
        public string Instructions { get; private set; }
    }
}
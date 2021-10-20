namespace Domain.Entities
{
    public class Store
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int SalesPersonID { get; set; }
        public string Demographics { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
    }
}
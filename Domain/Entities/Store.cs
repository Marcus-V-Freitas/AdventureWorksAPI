namespace Domain.Entities
{
    public class Store
    {
        public int? CustomerID { get; private set; }
        public string Name { get; private set; }
        public int? SalesPersonID { get; private set; }
        public string Demographics { get; private set; }

        public virtual Customer Customer { get; private set; }
        public virtual SalesPerson SalesPerson { get; private set; }
    }
}
namespace Domain.Entities
{
    public class Customer
    {
        public int CustomerID { get; private set; }
        public int TerritoryID { get; private set; }
        public string AccountNumber { get; private set; }
        public string CustomerType { get; private set; }

        public virtual SalesTerritory SalesTerritory { get; private set; }
    }
}
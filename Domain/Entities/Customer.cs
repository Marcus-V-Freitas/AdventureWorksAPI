namespace Domain.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int TerritoryID { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerType { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}
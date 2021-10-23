namespace Domain.Entities
{
    public class SalesPerson
    {
        public int? SalesPersonID { get; private set; }
        public int? TerritoryID { get; private set; }
        public double? SalesQuota { get; private set; }
        public double? Bonus { get; private set; }
        public double? CommissionPct { get; private set; }
        public double? SalesYTD { get; private set; }
        public double? SalesLastYear { get; private set; }

        public virtual SalesTerritory SalesTerritory { get; private set; }
    }
}
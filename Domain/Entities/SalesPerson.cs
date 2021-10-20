namespace Domain.Entities
{
    public class SalesPerson
    {
        public int SalesPersonID { get; set; }
        public int TerritoryID { get; set; }
        public double SalesQuota { get; set; }
        public double Bonus { get; set; }
        public double CommissionPct { get; set; }
        public double SalesYTD { get; set; }
        public double SalesLastYear { get; set; }
    }
}
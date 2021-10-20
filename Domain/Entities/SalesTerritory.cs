namespace Domain.Entities
{
    public class SalesTerritory
    {
        public int TerritoryID { get; set; }
        public string Name { get; set; }
        public string CountryRegionCode { get; set; }
        public string Group { get; set; }
        public double SalesYTD { get; set; }
        public double SalesLastYear { get; set; }
        public double CostYTD { get; set; }
        public double CostLastYear { get; set; }

        public virtual CountryRegion CountryRegion { get; set; }
    }
}
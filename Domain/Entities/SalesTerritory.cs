namespace Domain.Entities
{
    public class SalesTerritory
    {
        public int? TerritoryID { get; private set; }
        public string Name { get; private set; }
        public string CountryRegionCode { get; private set; }
        public string Group { get; private set; }
        public double? SalesYTD { get; private set; }
        public double? SalesLastYear { get; private set; }
        public double? CostYTD { get; private set; }
        public double? CostLastYear { get; private set; }

        public virtual CountryRegion CountryRegion { get; private set; }
    }
}
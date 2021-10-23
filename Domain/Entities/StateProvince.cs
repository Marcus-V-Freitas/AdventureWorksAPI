namespace Domain.Entities
{
    public class StateProvince
    {
        public int? StateProvinceID { get; private set; }
        public string StateProvinceCode { get; private set; }
        public string CountryRegionCode { get; private set; }
        public bool IsOnlyStateProvinceFlag { get; private set; }
        public string Name { get; private set; }
        public int? TerritoryID { get; private set; }

        public virtual CountryRegion CountryRegion { get; private set; }
        public virtual SalesTerritory SalesTerritory { get; private set; }
    }
}
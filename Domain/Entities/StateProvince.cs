namespace Domain.Entities
{
    public class StateProvince
    {
        public int StateProvinceID { get; set; }
        public string StateProvinceCode { get; set; }
        public string CountryRegionCode { get; set; }
        public int IsOnlyStateProvinceFlag { get; set; }
        public string Name { get; set; }
        public int TerritoryID { get; set; }

        public virtual CountryRegion CountryRegion { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}
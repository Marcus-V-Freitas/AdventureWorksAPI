namespace Domain.Entities
{
    public class CountryRegionCurrency
    {
        public string CountryRegionCode { get; set; }
        public string CurrencyCode { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
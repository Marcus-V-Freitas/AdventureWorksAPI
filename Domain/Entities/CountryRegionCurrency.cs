namespace Domain.Entities
{
    public class CountryRegionCurrency
    {
        public string CountryRegionCode { get; private set; }
        public string CurrencyCode { get; private set; }

        public virtual Currency Currency { get; private set; }
    }
}
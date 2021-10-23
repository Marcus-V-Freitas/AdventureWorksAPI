namespace Domain.Entities
{
    public class SalesTaxRate
    {
        public int? SalesTaxRateID { get; private set; }
        public int? StateProvinceID { get; private set; }
        public bool TaxType { get; private set; }
        public double? TaxRate { get; private set; }
        public string Name { get; private set; }

        public virtual StateProvince StateProvince { get; private set; }
    }
}
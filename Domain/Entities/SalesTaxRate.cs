namespace Domain.Entities
{
    public class SalesTaxRate
    {
        public int SalesTaxRateID { get; set; }
        public int StateProvinceID { get; set; }
        public bool TaxType { get; set; }
        public double TaxRate { get; set; }
        public string Name { get; set; }

        public virtual StateProvince StateProvince { get; set; }
    }
}
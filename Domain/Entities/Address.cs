namespace Domain.Entities
{
    public class Address
    {
        public int? AddressID { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string City { get; private set; }
        public int? StateProvinceID { get; private set; }
        public string PostalCode { get; private set; }

        public virtual StateProvince StateProvince { get; private set; }
    }
}
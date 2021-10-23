namespace Domain.Entities
{
    public class Vendor
    {
        public int? VendorID { get; private set; }
        public string AccountNumber { get; private set; }
        public string Name { get; private set; }
        public bool CreditRating { get; private set; }
        public bool PreferredVendorStatus { get; private set; }
        public bool ActiveFlag { get; private set; }
    }
}
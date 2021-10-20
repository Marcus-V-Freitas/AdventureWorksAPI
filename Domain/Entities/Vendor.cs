namespace Domain.Entities
{
    public class Vendor
    {
        public int VendorID { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public bool CreditRating { get; set; }
        public int PreferredVendorStatus { get; set; }
        public int ActiveFlag { get; set; }
    }
}
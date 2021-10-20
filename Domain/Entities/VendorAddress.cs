namespace Domain.Entities
{
    public class VendorAddress
    {
        public int VendorID { get; set; }
        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }

        public virtual Address Address { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual AddressType AddressType { get; set; }
    }
}
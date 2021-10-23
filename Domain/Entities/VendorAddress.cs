namespace Domain.Entities
{
    public class VendorAddress
    {
        public int? VendorID { get; private set; }
        public int? AddressID { get; private set; }
        public int? AddressTypeID { get; private set; }

        public virtual Address Address { get; private set; }
        public virtual Vendor Vendor { get; private set; }
        public virtual AddressType AddressType { get; private set; }
    }
}
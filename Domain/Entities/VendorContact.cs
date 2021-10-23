namespace Domain.Entities
{
    public class VendorContact
    {
        public int? VendorID { get; private set; }
        public int? ContactID { get; private set; }
        public int? ContactTypeID { get; private set; }

        public virtual Vendor Vendor { get; private set; }
        public virtual Contact Contact { get; private set; }
        public virtual ContactType ContactType { get; private set; }
    }
}
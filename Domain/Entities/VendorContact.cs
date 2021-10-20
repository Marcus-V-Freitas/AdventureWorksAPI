namespace Domain.Entities
{
    public class VendorContact
    {
        public int VendorID { get; set; }
        public int ContactID { get; set; }
        public int ContactTypeID { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual ContactType ContactType { get; set; }
    }
}
namespace Domain.Entities
{
    public class CustomerAddress
    {
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
    }
}
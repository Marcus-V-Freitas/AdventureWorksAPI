namespace Domain.Entities
{
    public class CustomerAddress
    {
        public int? CustomerID { get; private set; }
        public int? AddressID { get; private set; }
        public int? AddressTypeID { get; private set; }

        public virtual Customer Customer { get; private set; }
        public virtual Address Address { get; private set; }
        public virtual AddressType AddressType { get; private set; }
    }
}
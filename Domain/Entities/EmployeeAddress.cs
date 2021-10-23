namespace Domain.Entities
{
    public class EmployeeAddress
    {
        public int? EmployeeID { get; private set; }
        public int? AddressID { get; private set; }

        public virtual Employee Employee { get; private set; }

        public virtual Address Address { get; private set; }
    }
}
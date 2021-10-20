namespace Domain.Entities
{
    public class EmployeeAddress
    {
        public int EmployeeID { get; set; }
        public int AddressID { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Address Address { get; set; }
    }
}
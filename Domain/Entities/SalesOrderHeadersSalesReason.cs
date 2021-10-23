namespace Domain.Entities
{
    public class SalesOrderHeadersSalesReason
    {
        public int? SalesOrderID { get; private set; }
        public int? SalesReasonID { get; private set; }

        public virtual SalesReason SalesReason { get; private set; }
    }
}
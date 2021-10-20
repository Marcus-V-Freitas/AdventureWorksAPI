namespace Domain.Entities
{
    public class SalesOrderHeadersSalesReason
    {
        public int SalesOrderID { get; set; }
        public int SalesReasonID { get; set; }

        public virtual SalesOrderDetail SalesOrderDetail { get; set; }
        public virtual SalesReason SalesReason { get; set; }
    }
}
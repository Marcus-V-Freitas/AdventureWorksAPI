namespace Domain.Entities
{
    public class SalesOrderDetail
    {
        public int? SalesOrderID { get; private set; }
        public int? SalesOrderDetailID { get; private set; }
        public string CarrierTrackingNumber { get; private set; }
        public int? ProductID { get; private set; }
        public int? SpecialOfferID { get; private set; }
        public double? UnitPrice { get; private set; }
        public double? UnitPriceDiscount { get; private set; }
        public double? LineTotal { get; private set; }

        public virtual Product Product { get; private set; }
        public virtual SpecialOffer SpecialOffer { get; private set; }
    }
}
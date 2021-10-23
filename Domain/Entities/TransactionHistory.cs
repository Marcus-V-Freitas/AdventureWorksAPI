namespace Domain.Entities
{
    public class TransactionHistory
    {
        public int? TransactionID { get; private set; }
        public int? ProductID { get; private set; }
        public int? ReferenceOrderID { get; private set; }
        public int? ReferenceOrderLineID { get; private set; }
        public string TransactionType { get; private set; }
        public int? Quantity { get; private set; }
        public double? ActualCost { get; private set; }

        public virtual Product Product { get; private set; }
    }
}
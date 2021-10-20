namespace Domain.Entities
{
    public class TransactionHistoryArchive
    {
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public int ReferenceOrderID { get; set; }
        public int ReferenceOrderLineID { get; set; }
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
        public double ActualCost { get; set; }

        public virtual Product Product { get; set; }
        public virtual TransactionHistory TransactionHistory { get; set; }
    }
}
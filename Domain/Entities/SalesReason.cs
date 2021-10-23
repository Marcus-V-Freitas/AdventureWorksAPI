namespace Domain.Entities
{
    public class SalesReason
    {
        public int? SalesReasonID { get; private set; }
        public string Name { get; private set; }
        public string ReasonType { get; private set; }
    }
}
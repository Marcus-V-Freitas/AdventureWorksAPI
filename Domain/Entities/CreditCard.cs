namespace Domain.Entities
{
    public class CreditCard
    {
        public int CreditCardID { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public bool ExpMonth { get; set; }
    }
}
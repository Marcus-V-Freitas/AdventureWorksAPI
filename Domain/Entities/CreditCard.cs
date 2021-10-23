namespace Domain.Entities
{
    public class CreditCard
    {
        public int? CreditCardID { get; private set; }
        public string CardType { get; private set; }
        public string CardNumber { get; private set; }
        public bool ExpMonth { get; private set; }
    }
}
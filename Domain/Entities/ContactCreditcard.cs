namespace Domain.Entities
{
    public class ContactCreditcard
    {
        public int? ContactID { get; private set; }
        public int? CreditCardID { get; private set; }

        public virtual CreditCard CreditCard { get; private set; }
        public virtual Contact Contact { get; private set; }
    }
}
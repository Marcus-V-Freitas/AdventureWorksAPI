namespace Domain.Entities
{
    public class ContactCreditcard
    {
        public int ContactID { get; set; }
        public int CreditCardID { get; set; }

        public virtual CreditCard CreditCard { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
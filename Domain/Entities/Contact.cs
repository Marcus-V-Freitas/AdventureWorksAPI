namespace Domain.Entities
{
    public class Contact
    {
        public int? ContactID { get; private set; }
        public bool NameStyle { get; private set; }
        public string Title { get; private set; }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string Suffix { get; private set; }
        public string EmailAddress { get; private set; }
        public int? EmailPromotion { get; private set; }
        public string Phone { get; private set; }
        public string PasswordHash { get; private set; }
        public string PasswordSalt { get; private set; }
    }
}
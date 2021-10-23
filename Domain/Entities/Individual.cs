namespace Domain.Entities
{
    public class Individual
    {
        public int? CustomerID { get; private set; }
        public int? ContactID { get; private set; }
        public string Demographics { get; private set; }

        public virtual Customer Customer { get; private set; }
        public virtual Contact Contact { get; private set; }
    }
}
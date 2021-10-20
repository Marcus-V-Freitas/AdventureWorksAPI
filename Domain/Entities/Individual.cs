namespace Domain.Entities
{
    public class Individual
    {
        public int CustomerID { get; set; }
        public int ContactID { get; set; }
        public string Demographics { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
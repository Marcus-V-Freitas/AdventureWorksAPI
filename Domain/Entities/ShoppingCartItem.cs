namespace Domain.Entities
{
    public class ShoppingCartItem
    {
        public int? ShoppingCartItemID { get; private set; }
        public string ShoppingCartID { get; private set; }
        public int? Quantity { get; private set; }
        public int? ProductID { get; private set; }

        public virtual Product Product { get; private set; }
    }
}
namespace Domain.Entities
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; }
        public string ShoppingCartID { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}
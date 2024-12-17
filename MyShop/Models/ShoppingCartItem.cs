namespace MyShop.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public Bicycle Bicycle { get; set; }
        public int Quantity { get; set; }
    }
}
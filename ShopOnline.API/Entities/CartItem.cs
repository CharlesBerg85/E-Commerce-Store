namespace ShopOnline.API.Entities
{
    // These classes represent our entities that directly map to our database tables.

    public class CartItem
    {
        // Represents the unique identifier for the CartItem.
        public int Id { get; set; }

        // Represents the foreign key that links the CartItem to its associated Cart.
        public int CartId { get; set; }

        // Represents the foreign key that links the CartItem to its associated Product.
        public int ProductId { get; set; }

        // Represents the quantity of the Product in the CartItem.
        public int Qty { get; set; }
    }
}

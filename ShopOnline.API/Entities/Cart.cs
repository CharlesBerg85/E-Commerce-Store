namespace ShopOnline.API.Entities
{
    // These classes represent the entities that directly map to the corresponding database tables.
    // When creating entities for our database, it's important to establish relationships between them.
    // For example, in this Cart class, we have an Id property that can be linked to the CartItem entity, which also has an Id property.
    // We can further establish a relationship by noting that Product also relates to Cart and CartItem through the use of the Id property.

    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}

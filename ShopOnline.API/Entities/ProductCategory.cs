namespace ShopOnline.API.Entities
{
    // These classes represent our entities that directly map to our database tables.

    public class ProductCategory
    {
        // Represents the unique identifier for the ProductCategory.
        public int Id { get; set; }

        // Represents the name of the ProductCategory.
        public string? Name { get; set; }
    }
}

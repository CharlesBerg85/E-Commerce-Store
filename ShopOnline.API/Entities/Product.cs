namespace ShopOnline.API.Entities
{
    // These classes represent our entities that directly map to our database tables.

    public class Product
    {
        // Represents the unique identifier for the Product.
        public int Id { get; set; }

        // Represents the name of the Product.
        public string? Name { get; set; }

        // Represents the description of the Product.
        public string? Description { get; set; }

        // Represents the URL of the Product's image.
        public string? ImageURL { get; set; }

        // Represents the price of the Product.
        public decimal Price { get; set; }

        // Represents the quantity of the Product.
        public int Qty { get; set; }

        // Represents the foreign key that links the Product to its associated Category.
        public int CategoryId { get; set; }
    }
}


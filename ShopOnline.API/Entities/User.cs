namespace ShopOnline.API.Entities
{
    // These classes represent our entities that directly map to our database tables.
    // These entities were generated when we ran the relevant migration.
    // The purpose of these entities is to serve as blueprints for the corresponding database tables.

    public class User
    {
        // Represents the unique identifier for the User.
        public int Id { get; set; }

        // Represents the username of the User.
        public string? UserName { get; set; }
    }
}

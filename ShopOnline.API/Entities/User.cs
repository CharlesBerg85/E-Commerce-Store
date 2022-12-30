namespace ShopOnline.API.Entities
{
    //these classes represent our entites that directly map to our database tables
    //that is was genrerated when we ran the relevant migration 
    //the function these entites can be seen as blueprints for the corresponding database tables
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
    }
}

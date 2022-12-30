namespace ShopOnline.API.Entities
{
    //these classes represent our entites that directly map to our database tables
    //when creating our entites for our database we want to make to to alwaye have related properties
    //for example with this Cart class we have an Id which can be linked to cartItem which also had an Id
    //we could go even further and say that Product also has a reltion between Cart and CartItem which is Id
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}

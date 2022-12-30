namespace ShopOnline.API.Entities
{
    //these classes represent our entites that directly map to our database tables
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}

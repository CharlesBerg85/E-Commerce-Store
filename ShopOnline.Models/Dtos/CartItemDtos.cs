using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.Dtos
{
    //DTO Data Transfer Object
    //dot is an object that defines how the data will be sent over the network
    //when passing data between the server and the client, we sometimes dont want to send necessarily the exact data
    //defined by the properties in the classes that represent in the database entities
    //for example with in the class Product we have a CategoryId which is not something the user/client needs to see
    //the CategoryId properties within the product entity is a foreign key from the product category entity
    //it would be more conventinal to have the CategoryName in additon to the ProductInfo defined in the product class
    //when creating this model we still need to include all other properties as well as the ProductName
    //this type of model includes the data that needs to be passed between server and client  
    public class CartItemDtos
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CartId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string?  ProductImageURL { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set;}
        public int Qty { get; set; }


    }
}

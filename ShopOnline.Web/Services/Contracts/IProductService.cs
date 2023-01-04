using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contracts
{
    public interface IProductService
    {
        //We are going to wrap the functionality that handles calls to our web API component within services
        //Services are simply C# classes that wrap the functionality for handling interarion with our web API component
        //we want our method to run asynchronously so our method will return a Task object
        //In this case we are going to write code to reurn a generic task object becaise this method must return a value to the calling code
        //The value type is an IEnumerable collection of objects of type productDto
        Task<IEnumerable<ProductDto>> GetItems();
    }
}

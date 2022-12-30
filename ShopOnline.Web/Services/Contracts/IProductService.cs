using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contracts
{
    public interface IProductService
    {
        //we want our method to run asynchronously so our metho eill return a Task object
        Task<IEnumerable<ProductDto>> GetItems();
    }
}

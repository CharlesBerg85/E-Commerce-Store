using ShopOnline.API.Entities;

namespace ShopOnline.API.Repositories.Contracts
{
    //using the repository design pattern to abstract our data handling layer.
    //repostories are classes or componesnts that encapsulate the logic required to access data sources
    //we can use repositories to centalize common data access functionality
    //which has the benifit of facilitating better maintainability, easier unit testing, extensibility and cleaner code

    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<Product> GetItem(int id);
        Task<ProductCategory> GetCategory(int id);

    }
}



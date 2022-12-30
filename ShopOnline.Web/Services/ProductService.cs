using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System.Net.Http.Json;

namespace ShopOnline.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;
        //want to tell .NET we want a http client object to injected into our product service class
        //to do this we simply define a parameter of type http client
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                //create a variable to call the GetItems Action method
                //that resides within the product controller of our
                //web api component. Using GetFromJsonAsync we can return an
                //IEnumerable collection of type ProductDto
                //this method will translate the data which will be in json returned
                //from the web API Componenet to an object of type IEnumerable ProductDto
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

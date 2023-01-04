using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.API.Entities;
using ShopOnline.API.Extensions;
using ShopOnline.API.Repositories.Contracts;
using ShopOnline.Models.Dtos;

namespace ShopOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    //here an object of type productRepository is automatically injected into our controller
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        //constructor via depecdency injection
        public ProductController(IProductRepository productRepository) 
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {
                //this will call the productRepository class's getItem method asynchronously 
                //to return an IEnumerable collection of type product to our Action method
                var products = await this.productRepository.GetItems();
                //return an IEnumerable collection of type productCategories to our Action method
                var productCategories = await this.productRepository.GetCategories();

                if (products == null || productCategories == null) 
                {
                    return NotFound();
                }
                else
                {
                    //we want to join the collection of ProductCategories with the collection of Products
                    //this will return a collection of ProductDTOS to the Client and will also include 
                    //CategoryName, remember the productDto definition contiains a CategoryName property
                    //ConvertToDto is our extension method, this helps to keep our code cleaner 
                    //check extension method to read the code need to convertToDto 
                    
                    var productDtos = products.ConvertToDto((IEnumerable<Entities.ProductCategory>)productCategories);

                    return Ok(productDtos);
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }
    }
}

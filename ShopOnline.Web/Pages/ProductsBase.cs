using Microsoft.AspNetCore.Components;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages
{
    //in order for our ProductsBase class to be inherited from our Razor component
    //our Base class musht inherit from a class named ComponentBase which reside
    //within the Microsoft.AspNetCore.Components namespace
    public class ProductsBase:ComponentBase
    {
        [Inject]
        //this property will help facilitate dependency injection of an oject of type IProductService
        public IProductService ProductService { get; set; }
    }
}

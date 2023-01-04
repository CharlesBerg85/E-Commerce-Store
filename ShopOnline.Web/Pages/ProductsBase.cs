using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages
{
    //in order for our ProductsBase class to be inherited from our Razor component
    //our Base class musht inherit from a class named ComponentBase which reside
    //within the Microsoft.AspNetCore.Components namespace
    public class ProductsBase:ComponentBase
    {
        [Inject]
        //this property will help facilitate dependency injection of an object of type IProductService
        //this class also needs to be registed for dependency injection, this can be done by going to the Program.cs with in ShopOnline.Web
        public IProductService ProductService { get; set; }
        //This Property will expose an IEnumerable collection of objects of type productDto
        //this collection will be axxessible to the relevant razor code that we create
        public IEnumerable<ProductDto> Products { get; set; }
        //now we want our code that retrieves our product date from the server our web API component to run when the product's razor
        //component is first invoked. This can be done by overriding a function names OnInitializedAsync
        //This method is associated with a blazer lifecycle event 
        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }
    }
}

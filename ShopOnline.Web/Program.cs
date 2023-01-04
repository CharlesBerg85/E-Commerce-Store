using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopOnline.Web;
using ShopOnline.Web.Services;
using ShopOnline.Web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//Changing the Uri to our website address will help us to configure our blazor component to the appropriate local web api
//We will be using the HTTP client object to call relevant action methods within our web API component
//So in order for the Client component to point to the wen API component on our local machines the arguamtn in the Uri need to be replaced
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7065/") });
//Registed for dependency injection
builder.Services.AddScoped<IProductService, ProductService>();
await builder.Build().RunAsync();

using ShopOnline.API.Entities;
using ShopOnline.Models.Dtos;

namespace ShopOnline.API.Extensions
{
    //it is importain that the class that houses our extension method is static
    public static class DtosConversions
    {
        public static IEnumerable<ProductDto> /*Method Name*/ ConvertToDto(this IEnumerable<Product> products,
                                                            IEnumerable<ProductCategory> productCategories)
        {
            //using Linq methods this is joining the collection of the productCategories with the collection of product
            
            return (from product in products
                    join productCategory in productCategories
                    on product.CategoryId equals productCategory.Id
                    // this will return a collection of ProductDto by creating a new list 
                    select new ProductDto
                    {
                        Id = product.Id,
                        Name= product.Name,
                        Description= product.Description,
                        ImageURL= product.ImageURL,
                        Price= product.Price,
                        Qty= product.Qty,
                        CategoryId= product.CategoryId,
                        CategoryName= productCategory.Name
                    }).ToList();
        }
    }
}

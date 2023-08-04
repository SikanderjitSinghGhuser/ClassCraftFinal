using ClassCraftFinal.Models;
using ClassCraftFinal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassCraftFinal.Pages
{
    public class ProductListModel : PageModel
    {

        // Adding the public property of type "JsonFileProductService":
        public JsonFileProductService ProductService;

        /*
       Since the "ProductList.cshtml" will list the products of the json file,
        and it has the code @model "ProductListModel" which should have the list 

        Remember that we declared the products as IEnumerable 
        because it represents any list/collection in C#:
         */
        public IEnumerable<Product> Products { get; private set; } = default!;

        // Add a Constructor:
        /*
        The constructor uses dependency injection to add the 
        "JsonFileProductService" to the page.

        Create a custom constructor by adding our custom services like the JSON file to read:
        with the parameter named "productService" for example

        and we can add more services as we need...
        */
        public ProductListModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }
      
        public void OnGet()
        {
            // Finally :-)
            Products = ProductService.GetProducts();
        }
    } // class
}

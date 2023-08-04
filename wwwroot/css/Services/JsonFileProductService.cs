using ClassCraftFinal.Models;
using System.Text.Json;

namespace ClassCraftFinal.Services
{
    public class JsonFileProductService
    {
        // Class Constructor
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        // one more property for the JsonFileName
        /*
        private string JsonFileName
        {
            // get has to return the full location of your JSON file
            get {
                return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "products.json");
            }
        } */

        // Or using the short version:
        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json");

        /*
        Getting/retrieving the data (products) from the JSON file:
        adding a public method "GetProducts()"

        could be any method name that makes sense to you :-) 
        but the generics <?> has the name "Product"?
        because we have the "Product.cs" file inside the "Models" folder
        */

        public IEnumerable<Product> GetProducts()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            })!;
        }
    } // class
}

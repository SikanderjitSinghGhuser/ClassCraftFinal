using System.Text.Json.Serialization;

namespace ClassCraftFinal.Models
{
    /*
    "Id": 
    "Maker": 
    "img": 
    "Url": 
    "Title": 
    */
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }

        public int[]? Ratings { get; set; }
    }
}

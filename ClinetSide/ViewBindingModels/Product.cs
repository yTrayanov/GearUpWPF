using Newtonsoft.Json;

namespace ClientSide.ViewBindingModels
{
    public class Product
    {

        [JsonProperty("_Id")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}

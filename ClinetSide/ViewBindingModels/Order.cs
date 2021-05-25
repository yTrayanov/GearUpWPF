using Newtonsoft.Json;

namespace ClientSide.ViewBindingModels
{
    public class Order
    {
        [JsonProperty("_Id")]
        public string Id { get; set; }
        public string Address { get; set; }
        public string AddictionalInfo { get; set; }

        public Product Product { get; set; }
    }
}

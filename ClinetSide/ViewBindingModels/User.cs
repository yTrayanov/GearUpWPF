using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ClientSide.ViewBindingModels
{
    public class User
    {
        public User()
        {
            this.Orders = new List<Order>();
            this.Cart = new List<Product>();
        }

        public string UserId { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        [JsonIgnore]
        public ICollection<Order> Orders { get; set; }
        
        [JsonIgnore]
        public ICollection<Product> Cart { get; set; }
    }
}

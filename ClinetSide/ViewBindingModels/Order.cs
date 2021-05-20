using System;
using System.Collections.Generic;
using System.Text;

namespace ClientSide.ViewBindingModels
{
    public class Order
    {
        public string Address { get; set; }
        public string AddictionalInfo { get; set; }

        public Product Products { get; set; }
    }
}

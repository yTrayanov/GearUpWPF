using ClientSide.RequestServices;
using System.Windows.Controls;

namespace ClientSide.Views.Orders
{
    public abstract class OrderControl:UserControl
    {
        public OrderControl()
        {
            this.OrderService = new OrderService();
        }

        public OrderService OrderService { get; set; }
    }
}

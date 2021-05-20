using ClientSide.RequestServices;
using System.Windows.Controls;

namespace ClientSide.Views.Products
{
    public abstract class ProductControl : UserControl
    {
        public ProductControl()
        {
            this.ProductService = new ProductService();
        }

        public ProductService ProductService { get; set; }
    }
}
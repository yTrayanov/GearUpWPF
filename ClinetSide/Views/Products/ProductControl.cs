using ClientSide.RequestServices;
using ClientSide.ViewBindingModels;
using System.Windows;
using System.Windows.Controls;

namespace ClientSide.Views.Products
{
    public abstract class ProductControl : UserControl
    {
        public ProductControl()
        {
            this.ProductService = new ProductService();
        }

        protected ProductService ProductService { get; set; }

        protected string UserId
        {
            get {
                return (Application.Current.Resources["CurrentUser"] as CurrentUserBindingModel).User.UserId;
            }
        }
    }
}
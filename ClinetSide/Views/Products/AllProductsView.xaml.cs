using ClientSide.RequestServices;
using ClientSide.ViewBindingModels;
using System.Windows;

namespace ClientSide.Views.Products
{
    /// <summary>
    /// Interaction logic for AllProductsView.xaml
    /// </summary>
    public partial class AllProductsView : ProductControl
    {
        public AllProductsView()
        {
            InitializeComponent();

            var products = this.ProductService.GetAllProducts().Result;
            lbProducts.ItemsSource = products;
        }


        private void btnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            if(lbProducts.SelectedItem != null)
            {
                string productId = (lbProducts.SelectedItem as Product).Id;
                string userId = (Application.Current.Resources["CurrentUser"] as CurrentUserBindingModel).User.UserId;

                var response = this.ProductService.AddProductToCart(productId, userId).Result;
            }
        }
    }
}

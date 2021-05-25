using ClientSide.RequestServices;
using ClientSide.ViewBindingModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace ClientSide.Views.Products
{
    /// <summary>
    /// Interaction logic for AllProductsView.xaml
    /// </summary>
    public partial class AllProductsView : ProductControl
    {
        private ObservableCollection<Product> products;
        public AllProductsView()
        {
            InitializeComponent();

            products = new ObservableCollection<Product>(this.ProductService.GetAllProducts().Result);

            lbProducts.ItemsSource = products;

            bool isAdmin = (bool)Application.Current.MainWindow.GetType().GetProperty("IsAdmin").GetValue(Application.Current.MainWindow);
            if (isAdmin)
            {
                btnRemoveItem.Visibility = Visibility.Visible;
                btnAddToCart.Visibility = Visibility.Hidden;
            }
            else
            {
                btnAddToCart.Visibility = Visibility.Visible;
                btnRemoveItem.Visibility = Visibility.Hidden;
            }
        }


        private void btnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            if (lbProducts.SelectedItem != null)
            {
                string productId = (lbProducts.SelectedItem as Product).Id;
                string userId = (Application.Current.Resources["CurrentUser"] as CurrentUserBindingModel).User.UserId;

                var response = this.ProductService.AddProductToCart(productId, userId).Result;
            }
        }

        private void btnRemoveItem_Click(object sender, RoutedEventArgs e)
        {
            if (lbProducts.SelectedItem != null)
            {
                var product = (lbProducts.SelectedItem as Product);
                var response = this.ProductService.DeleteProduct(product.Id).Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButton.OK);
                    return;
                }

                this.products.Remove(product);
            }
        }
    }
}

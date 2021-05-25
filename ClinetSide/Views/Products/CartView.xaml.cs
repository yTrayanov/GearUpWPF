using ClientSide.RequestServices;
using ClientSide.ViewBindingModels;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace ClientSide.Views.Products
{
    /// <summary>
    /// Interaction logic for CartView.xaml
    /// </summary>
    public partial class CartView : ProductControl
    {
        private ObservableCollection<Product> products;
        private OrderService _orderService = new OrderService();
        private readonly string userId = (Application.Current.Resources["CurrentUser"] as CurrentUserBindingModel).User.UserId;
        public CartView()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>(this.ProductService.GetUserProducts(userId).Result);
            lbProducts.ItemsSource = products;
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            if (lbProducts.SelectedItem != null)
            {
                OrderPopup.Visibility = Visibility.Visible;
            }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            OrderPopup.Visibility = Visibility.Hidden;
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbProducts.SelectedItem != null)
            {
                var product = (lbProducts.SelectedItem as Product);
                var response = this.ProductService.RemoveProductFromCart(userId, product.Id).Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Something went wrong");
                    return;
                }

                products.Remove(product);


            }

        }

        private void btnPurchase_Click(object sender, RoutedEventArgs e)
        {
            if (lbProducts.SelectedItem != null)
            {
                var product = (lbProducts.SelectedItem as Product);
                string address = tbAddress.Text;
                string addictionalInfo = tbAddictionalInfo.Text;

                var response = this._orderService.CreateOrder(address, addictionalInfo, product.Id, userId).Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButton.OK);
                    return;
                }

                var deleteItem = this.ProductService.RemoveProductFromCart(userId, product.Id).Result;
                this.products.Remove(product);
                OrderPopup.Visibility = Visibility.Hidden;
                tbAddictionalInfo.Text = "";
                tbAddress.Text = "";

            }
        }

    }
}

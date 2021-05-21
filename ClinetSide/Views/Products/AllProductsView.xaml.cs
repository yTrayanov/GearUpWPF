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

        private void lbProducts_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbProducts.SelectedItem != null)
            {
                var selected = lbProducts.SelectedItem;
            }
        }
    }
}

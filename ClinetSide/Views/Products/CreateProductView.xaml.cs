using ClientSide.RequestServices;
using System.Windows;
using System.Windows.Controls;

namespace ClientSide.Views.Products
{
    /// <summary>
    /// Interaction logic for CreateProduct.xaml
    /// </summary>
    public partial class CreateProductView : ProductControl
    {
        public CreateProductView()
        {
            InitializeComponent();
        }

        private async void btnCreateProduct_Click(object sender, RoutedEventArgs e)
        {
            var productName = tbName.Text;
            decimal productPrice;
            var productImage = tbImage.Text;

            if(string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productImage) || !decimal.TryParse(tbPrice.Text , out productPrice) || productPrice <= 0)
            {
                MessageBox.Show("Invalid data" , "Error" , MessageBoxButton.OK);
                return;
            }

            var response = await  (new ProductService()).CreateProduct(productName, productImage, productPrice);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButton.OK);
            }

            tbName.Text = "";
            tbPrice.Text = "";
            tbImage.Text = "";
        }
    }
}

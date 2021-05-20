using ClientSide.RequestServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientSide.Views
{
    /// <summary>
    /// Interaction logic for CreateProduct.xaml
    /// </summary>
    public partial class CreateProductView : UserControl
    {
        private ProductService _productService = new ProductService();
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

            var response = await _productService.CreateProduct(productName, productImage, productPrice);

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

using ClientSide.RequestServices;

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
            //var products = this.ProductService.GetAllProducts().Result;
        }



    }
}

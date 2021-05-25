using ClientSide.ViewBindingModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ClientSide.Views.Orders
{
    /// <summary>
    /// Interaction logic for UserOrders.xaml
    /// </summary>
    public partial class UserOrders : OrderControl
    {
        private ObservableCollection<Order> _userOrders;
        private string userId = (Application.Current.Resources["CurrentUser"] as CurrentUserBindingModel).User.UserId;
        public UserOrders()
        {
            InitializeComponent();
            this._userOrders = new ObservableCollection<Order>(this.OrderService.GetUserOrders(userId).Result);
            lbOrders.ItemsSource = this._userOrders;
        }
    }
}

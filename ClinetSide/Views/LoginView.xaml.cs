using ClientSide.RequestServices;
using ClientSide.ViewBindingModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ClientSide.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        private AuthService _authService = new AuthService();
        public LoginView()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Password;

            CurrentUserBindingModel data = await this._authService.Login(username, password);

            if(data == null)
            {
                tbUsername.Text = "";
                tbPassword.Password = "";
                MessageBox.Show("Invalid username or password", "Invalid data", MessageBoxButton.OK);
                return;
            }

            var currentUser = (CurrentUserBindingModel)this.FindResource("CurrentUser");
            currentUser.Token = data.Token;
            currentUser.User.UserId = data.User.UserId;
            currentUser.User.Username = data.User.Username;
            currentUser.User.IsAdmin = data.User.IsAdmin;

            var property = Application.Current.MainWindow.GetType().GetProperty("IsLogged");
            property.SetValue(Application.Current.MainWindow, true);


        }

    }
}

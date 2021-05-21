using ClientSide.RequestServices;
using ClientSide.ViewBindingModels;
using System.Windows;
using System.Windows.Controls;

namespace ClientSide.Views.Auth
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : AuthControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Password;

            CurrentUserBindingModel data = await this.AuthService.Login(username, password);

            tbUsername.Text = "";
            tbPassword.Password = "";

            if (data == null)
            {
                MessageBox.Show("Invalid username or password", "Invalid data", MessageBoxButton.OK);
                return;
            }

            var currentUser = (CurrentUserBindingModel)this.FindResource("CurrentUser");
            currentUser.Token = data.Token;
            currentUser.User.UserId = data.User.UserId;
            currentUser.User.Username = data.User.Username;
            currentUser.User.IsAdmin = data.User.IsAdmin;

            Application.Current.Resources["IsLogged"] = true;
            Application.Current.MainWindow.GetType().GetProperty("IsLogged").SetValue(Application.Current.MainWindow, true);

            if (data.User.IsAdmin)
            {
                Application.Current.MainWindow.GetType().GetProperty("IsAdmin").SetValue(Application.Current.MainWindow, true);
            }


        }

    }
}

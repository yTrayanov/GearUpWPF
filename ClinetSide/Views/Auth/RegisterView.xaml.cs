using ClientSide.RequestServices;
using System.Windows;
using System.Windows.Controls;

namespace ClientSide.Views.Auth
{
    /// <summary>
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : AuthControl
    {
        public RegisterView()
        {
            InitializeComponent();
        }
        private async void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var username = tbUsername.Text;
            var email = tbEmail.Text;
            var password = tbPassword.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields", "Invalid data", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


            var response = await this.AuthService.Register(username, email, password);

            if (!response.IsSuccessStatusCode)
                MessageBox.Show("Invalid data");

            tbUsername.Text = "";
            tbEmail.Text = "";
            tbPassword.Password = "";
        }
    }

}

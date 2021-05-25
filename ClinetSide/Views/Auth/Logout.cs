using System.Windows;
using System.Windows.Controls;
using ClientSide.ViewBindingModels;

namespace ClientSide.Views.Auth
{
    public static class Logout
    {
        public static object GetLogout(ContentControl target)
        {
            return target.GetValue(LogoutUser);
        }

        public static void SetLogout(ContentControl target, object value)
        {
            target.SetValue(LogoutUser, value);
        }

        public static readonly DependencyProperty LogoutUser = DependencyProperty.RegisterAttached("Logout", typeof(object), typeof(Logout), new UIPropertyMetadata(OnLogout));

        static void OnLogout(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow;
            mainWindow.GetType().GetProperty("IsLogged").SetValue(mainWindow, false);
            mainWindow.GetType().GetProperty("IsAdmin").SetValue(mainWindow, false);

            Application.Current.Resources["CurrentUser"] = new CurrentUserBindingModel() { User = new UserInfo() };
        }
    }
}

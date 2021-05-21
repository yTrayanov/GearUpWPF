using ClientSide.ViewBindingModels;
using System.ComponentModel;
using System.Reflection;
using System.Windows;

namespace ClientSide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        private bool isLogged;
        private bool isAdmin = false;
        public MainWindow()
        {

            InitializeComponent();
            (Application.Current.Resources["CurrentUser"] as CurrentUserBindingModel).User = new UserInfo();
            Application.Current.Resources["IsLogged"] = false;
            this.DataContext = this;
        }

        public bool IsLogged
        {
            get { return this.isLogged; }
            set
            {
                if(value != this.IsLogged)
                {
                    this.isLogged = value;
                    NotifyPropertyChanged(nameof(IsLogged));
                }
            }
        }

        public bool IsAdmin 
        {
            get { return this.isAdmin; }
            set
            {
                if(value != this.isAdmin)
                {
                    this.isAdmin = value;
                    NotifyPropertyChanged(nameof(IsAdmin));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged !=null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.IsLogged = false;
            this.IsAdmin = false;
            Application.Current.Resources["CurrentUser"] = new CurrentUserBindingModel() { User = new UserInfo() };
        }
    }
}

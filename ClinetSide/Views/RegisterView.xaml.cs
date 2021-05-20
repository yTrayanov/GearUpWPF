﻿using ClientSide.RequestServices;
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
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : UserControl
    {
        private AuthService _authService = new AuthService();
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


            var response = await this._authService.Register(username, email, password);

            if (!response.IsSuccessStatusCode)
                MessageBox.Show("Invalid data");

            tbUsername.Text = "";
            tbEmail.Text = "";
            tbPassword.Password = "";
        }
    }

}
